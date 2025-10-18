using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System.Collections;
using TMPro;
using Thirdweb;
using System;

public class NFTAnalyzer : MonoBehaviour
{
    [Header("UI References")]
    private string userAddress;
    public TextMeshProUGUI resultText;            // Gán Text để hiển thị kết quả
    public Button targetButton;

    private string apiUrl = "https://nft-ai-backend.onrender.com/analyze-wallet-nfts";

    // 👉 Hàm này gán vào OnClick của nút

    private void Start()
    {
        resultText.gameObject.SetActive(false);
        targetButton.gameObject.SetActive(true);
        // Kiểm tra trạng thái eco-friendly
        if (PlayerDataManager.Instance != null && PlayerDataManager.Instance.ecoFriendly == 2)
        {
            // Ẩn button và hiện text
            targetButton.gameObject.SetActive(false);
            resultText.gameObject.SetActive(true);
            Debug.Log("Eco-Friendly bonus active — hiding button.");
        }

    }
    public async void OnAnalyzeButtonClicked()
    {
        try
        {
            // 🔹 Get Wallet Address
            userAddress = await ThirdwebManager.Instance.SDK.Wallet.GetAddress();
            resultText.text = "Checking...";
            resultText.gameObject.SetActive(true);
            targetButton.gameObject.SetActive(false);
            if (string.IsNullOrEmpty(userAddress))
            {
                Debug.LogWarning("Wallet address is empty.");
                return;
            }
            StartCoroutine(CallNFTAnalyzer(userAddress));
        }
        catch (Exception ex)
        {
            Debug.LogError(ex.Message);
        }
    }

    private IEnumerator CallNFTAnalyzer(string walletAddress)
    {
        // Tạo JSON payload
        string jsonData = "{\"wallet\":\"" + walletAddress + "\"}";
        byte[] bodyRaw = System.Text.Encoding.UTF8.GetBytes(jsonData);

        // Tạo request POST
        UnityWebRequest request = new UnityWebRequest(apiUrl, "POST");
        request.uploadHandler = new UploadHandlerRaw(bodyRaw);
        request.downloadHandler = new DownloadHandlerBuffer();
        request.SetRequestHeader("Content-Type", "application/json");

        // Gửi request
        yield return request.SendWebRequest();

        // Kiểm tra lỗi
        if (request.result == UnityWebRequest.Result.ConnectionError ||
            request.result == UnityWebRequest.Result.ProtocolError)
        {
            Debug.LogError("API Error: " + request.error);
            resultText.text = "API Error: " + request.error;
        }
        else
        {
            Debug.Log("Response: " + request.downloadHandler.text);
            //resultText.text = request.downloadHandler.text;

            string jsonResponse = request.downloadHandler.text;
            Debug.Log("Response: " + jsonResponse);

            // 🔹 Parse JSON
            NFTResponse data = JsonUtility.FromJson<NFTResponse>(jsonResponse);

            // 🔹 Cập nhật UI
            resultText.gameObject.SetActive(true);

            // 🔹 Kiểm tra điều kiện và gán biến trong Singleton
            if (data.eco_friendly_count >= 1)
            {
                PlayerDataManager.Instance.ecoFriendly = 2;
                Debug.Log("Eco-Friendly Bonus Activated! x2 Rewards");
                resultText.text = "Eco Brother! Your Reward x2!";
            }
            else
            {
                PlayerDataManager.Instance.ecoFriendly = 1;
                Debug.Log("No Eco NFT found. Default reward x1");
                resultText.text = "No Eco NFT found.";
            }
        }
    }
}

[System.Serializable]
public class NFTResponse
{
    public int eco_friendly_count;
    public int total_nfts;
    public string wallet;
}
