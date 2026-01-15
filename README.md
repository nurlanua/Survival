## 📜 README — Simple RPG in C# (Tutorial Project)  
### 🎲 Simple RPG Game — Built in C#

This repository contains a console-based RPG game implemented in C# as part of a step-by-step learning project following Scott Lilly’s “Learn C# by Building a Simple RPG” tutorial:

➡️ https://scottlilly.com/learn-c-by-building-a-simple-rpg-index/

The game demonstrates foundational software engineering principles through an interactive adventure game featuring combat, inventory, character progression, and modular design.

### 🧠 Purpose

This project was built to deepen understanding of:

 - C# language and .NET fundamentals

 - Object-oriented programming (OOP)

 - Game logic and state management

 - Structuring a medium-sized C# codebase

 - Designing reusable and extensible classes

It’s intended for learning, experimentation, and demonstration of core programming competencies.

### 🚀 Features Implemented (Up to Lesson 18)

✔ Player creation and character stats  
✔ Enemy and battle system  
✔ Turn-based combat logic  
✔ Inventory and item effects  
✔ Weapons, potions, and consumables  
✔ Experience and leveling  
✔ Modular class structure  
✔ Separation of concerns (game logic vs UI)  

### 🛠 Built With
| Technology         | Purpose                       |
| ------------------ | ----------------------------- |
| **C#**             | Primary programming language  |
| **.NET**           | Console application framework |
| **OOP Principles** | Architecture & design         |
| **Git & GitHub**   | Version control & portfolio   |


### 📁 Project Structure
```
├── engine/
│     ├── LivingCreature.cs
│          ├── Player.cs
│          ├── Monster.cs
│     ├── Item.cs
│          ├── HealingPotion.cs
│          ├── Weapon.cs
│     ├── InventoryItem.cs
│     ├── Location.cs
│     ├── LootItem.cs
│     ├── PlayerQuest.cs
│     ├── Quest.cs
│     ├── QuestCompletionItem.cs
│     ├── RandomNumberGenerator.cs
├── Survival/
│     ├── Survival.cs
│     ├── Program.cs
│
└── README.md
```


### ▶ How to Run the Game
#### Prerequisites

.NET Framework 4.8.1 (download from [https://dotnet.microsoft.com/](https://dotnet.microsoft.com/en-us/download/dotnet-framework))  

#### Running Locally

 - ⬇️ Download a file named FULL  
 - ▶️ Run Survival.exe  


### 🧾 Gameplay Overview

When starting:

You create a player character with basic stats

You encounter enemies in turn-based combat

You can use items like weapons and potions

The game loops through encounters and updates player state until the end of the game.

### 📚 What I Learned

This tutorial project helped me gain practical experience in:

Coding

✔ Class design and inheritance  
✔ Encapsulation and object composition  
✔ Game algorithms and logic  

Engineering practices

✔ Breaking problems into small, manageable pieces  
✔ Code organization and maintainability  
✔ Debugging real logic paths  


### 📌 Notes

This project is based on a published tutorial series by Scott Lilly.
It is not a commercial product — it is an educational prototype.
