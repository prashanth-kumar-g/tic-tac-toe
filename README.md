# tic-tac-toe

---

📋 Table of Contents

- [Overview](#-overview)  
- [Demo Video](#-demo-video)  
- [Tech Stack](#-tech-stack)  
- [Features](#-features)  
- [Screenshots](#%EF%B8%8F-screenshots)  
- [Installation](#-installation)  
- [Developer Notes](#-developer-notes)  
- [Contributing](#-contributing)  
- [License](#-license)  
- [Copyright](#%EF%B8%8F-copyright)

---

## 🎯 Overview

✨ **Tic Tac Toe** is a polished Windows desktop application built with VB .NET and Windows Forms to bring the timeless 3×3 grid game to your PC. It offers both **Human‑vs‑Human** and **Human‑vs‑Computer** modes, with randomized turn order and dynamic player‑color assignment for a fresh experience every game. The intuitive button‑based interface makes moves quick and error‑proof, while built‑in win/draw detection and seamless restart/back controls keep gameplay flowing. Packaged in a one‑click installer that bundles the executable, configuration, and image assets, Tic Tac Toe delivers effortless setup and endless fun.

---

## 🎥 Demo Video

<div>
  <a href="https://www.youtube.com/watch?v=KJ-x_fkpHKM" target="_blank">
    <img src="https://github.com/user-attachments/assets/e871b196-b1ee-4bdf-aa73-88011abd51a7" alt="TicTacToe Demo" width="480">
  </a>
</div>

> ▶️ Click the thumbnail above to watch the full Tic Tac Toe demo on YouTube.

📘 This demo video provides a complete walkthrough of Tic Tac Toe, covering game launch, mode selection (Human vs Human & Human vs Computer), player name entry, randomized turn order and colors, in‑game play with win/draw detection, and using the Restart and Back controls. If you’re new to the project or need a quick overview, please watch this video before installing.

---

## 🛠 Tech Stack

- **Language:** Visual Basic .NET  
- **UI Framework:** Windows Forms .NET Framework 4.8
- **IDE:** Visual Studio 2017+  
- **Installer:** Inno Setup (`TicTacToe_Installer.iss`)    

---

## ✨ Features

- 🎮 **Two Play Modes**  
  - **Human vs Human:** Pass‑and‑play mode for two local players  
  - **Human vs Computer:** Uses simple random number logic to select from available cells  

- 🔀 **Randomized Experience**  
  - Randomized starting player each new game  
  - Dynamic assignment of X/O colors per player  

- 🔲 **Interactive 3×3 Grid**  
  - Buttons disable after selection to prevent duplicate moves  
  - Automatic win/draw detection with immediate pop‑up messages  

- 🔄 **Game Controls**  
  - **Restart:** Clears board, re‑randomizes turn and colors  
  - **Back:** Returns to the mode selection menu  
  - **Exit:** Closes the application cleanly  

- 📦 **Seamless Deployment**  
  - One‑click installer bundles the EXE, config, assets, and shortcuts  

---

## 🖼️ Screenshots

Below are complete interface screenshots from the Tic Tac Toe application, covering all key screens and interactions — including splash screen, home menu, player setup, gameplay in both modes, win/draw detection, and navigation controls.

<table>
  <tr>
    <td><img src="https://github.com/user-attachments/assets/197ad824-4ac5-4bdb-86bd-082ed33e2940" width="700"/></td>
  </tr>
  <tr>
    <td><img src="https://github.com/user-attachments/assets/12167c2f-850c-4cdc-b89d-257838100d88" width="700"/></td>
  </tr>
  <tr>
    <td><img src="https://github.com/user-attachments/assets/0ddc32c6-4b5d-4a45-bbab-e0a033067463" width="700"/></td>
  </tr>
  <tr>
    <td><img src="https://github.com/user-attachments/assets/32980897-b264-4709-8350-d668aecaffd3" width="700"/></td>
  </tr>
  <tr>
    <td><img src="https://github.com/user-attachments/assets/3bacccce-7b36-46bd-b86e-a46ce692af69" width="700"/></td>
  </tr>
  <tr>
    <td><img src="https://github.com/user-attachments/assets/4b941c5c-5b83-497e-aa40-b33e883691f2" width="700"/></td>
  </tr>
  <tr>
    <td><img src="https://github.com/user-attachments/assets/74737a11-ad00-4b51-8b47-cb7b0b07c1d8" width="700"/></td>
  </tr>
</table>

> 🖼️ This gallery includes all major screens and game workflows for full visual context.

---

## 🚀 Installation

1. **Download the Installer**  
   Grab `TicTacToe_Setup.exe` from the [Releases](https://github.com/prashanth-kumar-g/tic-tac-toe/releases/tag/v1.0.0/TicTacToe_Setup.exe) page.

2. **Run the Installer**  
   Double-click `TicTacToe_Setup.exe` and follow the prompts. It installs the game, creates Desktop/Start Menu shortcuts, and requires no further setup.

3. **Play the Game**  
   Launch from your shortcut, select a mode, and enjoy!

> 💡 No additional frameworks or manual configuration required.

---

## 🧑‍💻 Developer Notes

Contributors and curious developers can find more details here:

- **Solution & Project:** `Tic Tac Toe.sln` and `Tic Tac Toe.vbproj` target .NET Framework 4.x  
- **Key Code Files:**  
  - `SplashScreen.vb` – Startup animation  
  - `HomeForm.vb` – Mode selection & name input  
  - `PlayForm.vb` – Game logic, AI, win/draw detection  
  - `VariableModule.vb` – Shared player names and flags  
- **Installer:** Open `TicTacToe_Installer.iss` in Inno Setup Compiler to rebuild the setup

> ⚠️ End users do not need this section. This information is intended for developers who wish to explore the source code, understand the game flow, or rebuild the setup installer manually.

---

## 🤝 Contributing

Contributions are welcome!

If you'd like to improve this Tic Tac Toe game, fix bugs, or add new features:

- Fork the repository  
- Create a new branch for your changes  
- Submit a pull request with a clear explanation  

You can also open issues for suggestions or questions.  
Thank you for supporting simple and fun open-source projects!

---

## 📜 License

This project is licensed under the [CC BY-NC 4.0 License](LICENSE).  
You may use and modify this code for personal or educational purposes—see `LICENSE` for full details.

---

## ©️ Copyright

© 2025 Prashanth Kumar G. All rights reserved.  
Unauthorized commercial use or redistribution is prohibited without prior written consent.

---
