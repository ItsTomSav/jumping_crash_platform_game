# 🎮 Jumping Crash

A 3D platformer game developed in **Unity (2022.3.8)** using **C# scripts** for gameplay mechanics, UI management, and audio control.  
Inspired by classic platformers like *Super Mario 64*, *Crash Bandicoot*, and *ALTF4*, this project was developed as part of the *Human-Machine Interaction* course at **Politecnico di Bari**.

---

## 🧠 Overview
**Jumping Crash** is a 3D platformer game where the player controls a character named *Crash* through multiple levels filled with traps, moving obstacles, and enemies.  
The main goal is to **collect all coins** and **reach the portal** before the timer expires, combining precision, timing, and awareness.

The project demonstrates advanced use of **Unity Engine** components such as:
- Physics and collision systems  
- Animation controllers  
- Scene management and UI logic  
- Audio Mixer for adaptive sound design  

---

## 🧰 Technologies & Tools
- ![Unity](https://img.shields.io/badge/Unity-2022.3.8-black?style=flat-square&logo=unity)
- ![C#](https://img.shields.io/badge/C%23-Scripting-blue?style=flat-square&logo=csharp)
- ![Audio Mixer](https://img.shields.io/badge/Audio%20Mixer-Sound%20Design-orange?style=flat-square)
- ![Blender](https://img.shields.io/badge/3D%20Models-Blender%20%26%20Unity%20Assets-ff69b4?style=flat-square)

---

## 🕹️ Gameplay Overview

At the start, the player is welcomed by an interactive **Main Menu**, where they can start the game, access the tutorial, or modify audio settings.  
The menu design uses Unity UI components and animated transitions for a smooth experience.

<p align="center">
  <img src="images/main_menu.png" alt="Main Menu" width="600"/>
</p>

When the player start the game, this is the screen scene:
<p align="center">
  <img src="images/game_screen.png" alt="Gameplay Scene" width="600"/>
</p>

From the **Pause Menu**, players can resume, restart, or quit the level.
<p align="center">
  <img src="images/pause_menu.png" alt="Pause Menu" width="600"/>
</p>

**Options** allow sound configuration and access to the control instructions.
<p align="center">
  <img src="images/option_menu.png" alt="Options Menu" width="600"/>
</p>

The game is composed of **multiple scenes**:
- **Tutorial Scene**: introduces controls and basic movement.  
- **Four main levels**: progressively harder, with moving platforms, traps, and enemies.  
- **End Screen**: shows player score and stars based on completion time.

<p align="center">
  <img src="images/scenes.png" alt="Scenes Overview" width="600"/>
</p>

### 🧭 Controls
- `W`, `A`, `S`, `D` → Move  
- `Space` → Jump  
- `ESC` → Pause Menu  

---

## ⚙️ Level Design

Each level introduces new gameplay elements that challenge the player’s precision and timing:

- **Moving and rotating platforms**
- **Traps and spiked enemies**
- **Cannons shooting projectiles**
- **Swinging traps**, **falling logs**, and **wind blades**

Here are some examples of in-game enemies and obstacles:

<p align="center">
  <img src="images/spine_enemy.png" alt="Spiked Enemy" width="250"/>
  <img src="images/spine_ball.png" alt="Spiked Ball" width="100"/>
  <img src="images/spine_wall.png" alt="Spiked Wall" width="250"/>
</p>

<p align="center">
  <img src="images/eolic_enemy.png" alt="Eolic Enemy" width="150"/>
  <img src="images/cannon_ball.png" alt="Cannon Ball" width="250"/>
  <img src="images/woods_spawner.png" alt="Wood Spawner" width="250"/>
</p>

When completing a level, the **Level Complete Screen** displays the player’s performance with stars based on completion time and coins collected.

<p align="center">
  <img src="images/complete_level_screen.png" alt="Level Complete Screen" width="600"/>
</p>

The environment design balances difficulty with player engagement, ensuring a progressive learning curve and rewarding exploration.

---

## 🔊 Audio Management

The game’s audio system is managed using Unity’s **Audio Mixer**.  
Each scene includes background music and contextual sound effects (jump, collision, coin collection).  
Volume preferences are saved persistently through `PlayerPrefs`, maintaining the user’s audio settings even after closing the game.

<p align="center">
  <img src="images/audio_mixer.png" alt="Unity Audio Mixer" width="200"/>
</p>

---

## 🧩 Game Structure

The project is organized as follows:

| Folder | Description |
|---------|-------------|
| **Assets/Audio/** | Contains background music, sound effects, and UI sounds. |
| **Assets/Materials/** | Includes materials and shaders used in the game environment. |
| **Assets/Models/** | 3D models such as the player, enemies, traps, and environmental objects. |
| **Assets/Prefabs/** | Prefabricated reusable objects used throughout multiple scenes. |
| **Assets/Scenes/** | Contains all game scenes: main menu, tutorial, levels, and end screen. |
| **Assets/Scripts/** | C# scripts managing gameplay logic, UI, physics, and audio. |
| **Assets/Textures/** | Textures and visual assets applied to models and materials. |
| **Assets/UI/** | User interface elements such as menus, sliders, and buttons. |

Each folder is structured for modularity, making the project scalable and easy to maintain.


---

## 🧪 Key Features

- Smooth **3D movement** and physics-based collisions  
- Modular **UI system** with menus and sound feedback  
- **Countdown timer** with visual and audio warnings  
- **Particle systems** for explosions, hits, and coins  
- **Level-based progression** with scoring and star ranking

---

## 💡 Technical Highlights

- Developed using **Object-Oriented Programming (OOP)** in C#  
- Modular scripts for player movement, audio, and UI  
- Advanced use of **Unity physics** for moving platforms and objects  
- Persistent game data using **PlayerPrefs**  
- Organized project hierarchy for scalability  

---

## 👥 Authors

Developed by  
**[Tommaso Savino](https://github.com/ItsTomSav)** and **[Francesco Savino](https://github.com/FrankSav80)**  
*Master’s Degree in Automation Engineering* — Politecnico di Bari  

---

## 🧾 License

This project was developed for educational purposes under the *Human-Machine Interaction* course.  
All assets and code are original or used under educational license.

---
