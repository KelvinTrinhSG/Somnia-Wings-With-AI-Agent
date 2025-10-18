<h1 >Somnia – Wings With AI Agent 🪽🤖</h1>
<p >Fly, dodge, and soar through endless skies — powered by AI and Web3 on Somnia.</p>

---

### 🌍 Overview
**Somnia – Wings With AI Agent** is an **endless runner** where you glide through floating rings, dodge obstacles, and aim for the highest score possible.  
The longer you survive, the faster it gets — testing your reflexes and precision flight control.  

Built for the **Somnia Hackathon**, this game combines classic endless-runner gameplay with **AI-powered analysis** and **Web3 ownership**, offering a unique fusion of entertainment, intelligence, and blockchain rewards.

🎮 **Play now:** [thkien85.itch.io/somnia-wings-with-ai-agent](https://thkien85.itch.io/somnia-wings-with-ai-agent)  
📦 **Source:** [github.com/KelvinTrinhSG/Somnia-Wings-With-AI-Agent](https://github.com/KelvinTrinhSG/Somnia-Wings-With-AI-Agent)

---

### 🚀 Gameplay
- **Fly & Navigate** – Tap or click to control your flight.  
- **Pass Through Rings** – Each successful ring boosts your score.  
- **Avoid Obstacles** – Colliding with walls or obstacles costs you a life.  
- **Endless Challenge** – Speed and difficulty increase over time.  
- **3 Lives System** – You start each run with 3 lives. Lose them all — it’s game over.  
- **AI Score Boost (New!)** – If you own any eco-friendly NFTs, your score multiplier doubles automatically.

---

### 🌐 Web3 Features (Somnia)
| Feature | Type | Symbol | Description | Cost |
|----------|------|---------|--------------|------|
| **Token Gate NFT** | OpenEditionERC721 | **GATE** | Grants access to exclusive content and gated in-game areas. | **Free** |
| **VIP NFT** | OpenEditionERC721 | **VIP** | Unlocks premium perks: faster progression, VIP-only events, and early content. | **1 STT** |
| **GEM Token** | ERC20 Token Drop | **GEM** | Utility token for spinning the Fortune Wheel and earning bonus rewards. | **0.1 STT** |

**🧾 Contract Details**

#### 🔹 The Token Gate NFT  
- **Type:** OpenEditionERC721  
- **Symbol:** GATE  
- **Address:** [`0x2aC7e980C8769302FEB90d4480A562d81f88dD96`](https://shannon-explorer.somnia.network/address/0x2aC7e980C8769302FEB90d4480A562d81f88dD96)  
- **Thirdweb Contract:** [View on Thirdweb](https://thirdweb.com/team/kelvincod/0e7eed2e2e708515a11d78eaedf37f02/contract/50312/0x2aC7e980C8769302FEB90d4480A562d81f88dD96)  
- **Claim Condition:** Free  

#### 🔹 The VIP NFT  
- **Type:** OpenEditionERC721  
- **Symbol:** VIP  
- **Address:** [`0xB2Ee1F27fC8a50A5138B7Ae0f85Cc4C3813f58ba`](https://shannon-explorer.somnia.network/address/0xB2Ee1F27fC8a50A5138B7Ae0f85Cc4C3813f58ba)  
- **Thirdweb Contract:** [View on Thirdweb](https://thirdweb.com/team/kelvincod/0e7eed2e2e708515a11d78eaedf37f02/contract/50312/0xB2Ee1F27fC8a50A5138B7Ae0f85Cc4C3813f58ba)  
- **Claim Condition:** Costs 1 STT  

#### 🔹 The GEM Token  
- **Type:** ERC20 Token Drop  
- **Symbol:** GEM  
- **Address:** [`0x127B90a8b927ceE5fD3eB4aA98FadFC46c9C1d37`](https://shannon-explorer.somnia.network/address/0x127B90a8b927ceE5fD3eB4aA98FadFC46c9C1d37)  
- **Thirdweb Contract:** [View on Thirdweb](https://thirdweb.com/team/kelvincod/0e7eed2e2e708515a11d78eaedf37f02/contract/50312/0x127B90a8b927ceE5fD3eB4aA98FadFC46c9C1d37)  
- **Claim Condition:** Costs 0.1 STT  

---

### 🧠 AI Integration
The **AI Agent System** runs on a backend service that bridges **Somnia Explorer** and **OpenAI API** to dynamically enhance gameplay based on a player’s NFT portfolio.

#### ⚙️ How It Works
1. When a player connects their wallet, the backend queries **Somnia Explorer** to retrieve all NFTs owned by that wallet.  
2. The **AI Agent** (powered by **OpenAI API**, similar to ChatGPT) analyzes each NFT’s **name** and **metadata**.  
3. It determines whether any NFTs are **eco-friendly**, based on title keywords or metadata traits.  
4. If at least one eco-friendly NFT is detected, the backend sets the flag `PlayerDataManager.Instance.ecoFriendly = 2`.  
5. This triggers a **2× score multiplier** in-game, rewarding environmentally conscious collectors.  
6. The Unity client displays confirmation and adjusts the scoring system in real time.

#### 🧩 Architecture Overview
- **Backend:** Python Server  
- **Blockchain Layer:** Somnia Explorer API for NFT retrieval  
- **AI Layer:** OpenAI GPT API for semantic analysis of NFT data  
- **Game Client:** Unity (C#) using Web Requests to fetch AI evaluation results  
- **Web3 Sync:** Player wallet → Backend → AI Analysis → Score Boost

#### 💡 Why It Matters
This system transforms static NFTs into **dynamic gameplay modifiers**.  
By letting AI interpret blockchain data, every wallet becomes a unique profile — meaning your digital identity now influences your in-game experience.

---

### 🛠 How to Clone & Run Locally

#### Prerequisites
- Unity **2022.3+ (LTS recommended)**  
- **Git**  
- **Thirdweb Unity SDK** installed  
- Internet connection (for Web3 & AI backend calls)

#### 1️⃣ Clone the repository
```bash
git clone https://github.com/KelvinTrinhSG/Somnia-Wings-With-AI-Agent.git
cd Somnia-Wings-With-AI-Agent
```

#### 2️⃣ Open in Unity
- Open **Unity Hub → Add Project from Disk →** select the cloned folder.  
- Let Unity import all dependencies.

#### 3️⃣ Configure Web3
- Install **Thirdweb Unity SDK** (if not already).  
- In your Web3 config or ScriptableObject, set:
  - RPC: Somnia (testnet or mainnet)
  - Token Gate NFT: `0x2aC7e980C8769302FEB90d4480A562d81f88dD96`
  - VIP NFT: `0xB2Ee1F27fC8a50A5138B7Ae0f85Cc4C3813f58ba`
  - GEM Token: `0x127B90a8b927ceE5fD3eB4aA98FadFC46c9C1d37`

Connect your wallet for claiming NFTs or GEM spins.

#### 4️⃣ Run / Build
- **In Editor:** Press ▶️ Play  
- **WebGL:** `File → Build Settings → WebGL → Build and Run`  
- Deploy to **Itch.io** or your preferred host.

---

### 🧩 Tech Stack
- **Unity (C#)**  
- **Thirdweb Unity SDK** (NFT, ERC20, claims & spins)  
- **Somnia blockchain (STT token)**  
- **Python Backend**  
- **OpenAI API (GPT)** for NFT metadata interpretation  

---

### 🎯 Vision
Our vision is to combine **AI reasoning** with **Web3 transparency** — where your wallet is more than an address, it’s part of who you are in the game.  
Owning NFTs that represent sustainability or creativity now has real gameplay meaning.  

**Somnia – Wings With AI Agent** shows how blockchain data and artificial intelligence can work together to personalize experiences, reward responsibility, and build a smarter, more meaningful gaming world.

---

### 🤝 Contributing
Pull requests are welcome!

1. Fork the repo  
2. Create a new branch: `feat/your-feature`  
3. Commit your changes  
4. Open a PR with a short summary

### 📜 License
MIT — Feel free to use, remix, and build upon this project.  
Please credit **Somnia – Wings With AI Agent** when you do.
