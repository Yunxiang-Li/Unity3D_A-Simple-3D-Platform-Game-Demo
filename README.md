# Unity3D_A-Simple-3D-Platform-Game-Demo

[![standard-readme compliant](https://img.shields.io/badge/readme%20style-standard-brightgreen.svg?style=flat-square)](https://github.com/RichardLitt/standard-readme)

A simple 3d platform game based on Unity3D game engine.

## Table of Contents

- [Background](#Background)
- [Exhibition](#Exhibition)
- [Install](#install)
- [Usage](#usage)
- [Structure](#Structure)
- [Maintainers](#Maintainers)
- [License](#license)

## Background

This is a very simple 3D platform game demo made by Unity3D Engine according to the [Jimmy vegas Unity Tutorials](https://jvunity.weebly.com/).

In this game demo, user needs to go from the start position to the end position. User can control the character(Unity Chan in this game) walking and running by pressing (holding) **W, A, S, D** buttons or **arrow** buttons, jumping by pressing **E** button.

There are several blocks and gems with different materials in this game, player can collect gems to gain scores. Gems with different color have different scores(**silver** for **500** score, green for **1000** score and **red** for **1500** score). If the player falls out of the platform then the player is dead.

When the player goes to the end position successfully, total earned score is displayed, player position is freezed and a fade out effect appear and the level ends.

## Exhibition

<div align="center"> <img src="https://github.com/Yunxiang-Li/Unity3D_A-Simple-3D-Platform-Game-Demo/blob/master/Screenshots%20and%20GIFs/Level001Succeed.gif"/> </div>

<div align="center"> <img src="https://github.com/Yunxiang-Li/Unity3D_A-Simple-3D-Platform-Game-Demo/blob/master/Screenshots%20and%20GIFs/Level001Fail.gif"/> </div>

<div align="center"> <img src="https://github.com/Yunxiang-Li/Unity3D_A-Simple-3D-Platform-Game-Demo/blob/master/Screenshots%20and%20GIFs/ResetScore.gif"/> </div>

<div align="center"> <img src="https://github.com/Yunxiang-Li/Unity3D_A-Simple-3D-Platform-Game-Demo/blob/master/Screenshots%20and%20GIFs/Credits.gif"/> </div>

## Install

I use Unity2019.3.11f1 and JetBrain's Rider IDE for this project under Windows 10 environment.<br>
[Unity and Unity hub download](https://unity3d.com/get-unity/download)<br>
[archived Unity download ](https://unity3d.com/get-unity/download/archive)<br>
[Jetbrains Rider download](https://www.jetbrains.com/rider/download/#section=windows)

## Usage

1. Download this repo, open(or zip and open) the **Unity3D_A-Simple-3D-Platform-Game-Demo** folder.

2. Open the **Unity Hub**, from the Home Screen, click **Projects** to view the **Projects** tab.

3. To open an existing Unity Project stored on your computer, click the Project name in the **Projects** tab, or click **Open** to browse your computer for the Project folder.

4. Note that a Unity Project is a collection of files and directories, rather than just one specific Unity Project file. To open a Project, you must select the main Project folder, rather than a specific file).

5. For this game, just select the **Unity3D_A-Simple-3D-Platform-Game-Demo** folder and open this project.

## Structure

The whole project in Unity contains two main folders, **Assets** folder and **Package** folder.

Under **Assets** folder, there are altogether **11** subfolders:

1. Animation folder: contains **8** animations we will use in this game including **fade in / out**, **platform movement** and so on.

2. Audio folder: contains **6** sound files we will use in this game including **Main Menu BGM**, **Click sound**, **Pause Game sound** and so on.

3. Fonts folder: contains **1** font we will use in this game(**Good Times** font).

4. Materials folder: contains **11** materials we will use in this game including **Floor material**, **Gem material**, **Finish Game material** and so on.

5. Objects folder: contains gem objects we will use in this game, there are also several sub folders(prefabs, gems and models) under this folder.

6. Prefabs folder: contains **3** prefabs we will use in this game including **DoubleBaseBlock** and so on.

7. Scences folder: contains **5** scenes, including **Main Menu Scene**, **Level 001**, **Credits** and so on.

8. Scripts folder: contains all **16** customized C# scripts we need in this game demo. 

9. SkyBox folder: contains skyboxes we need in this game demo. Download from the Unity Asset Store, you can download them [here](https://assetstore.unity.com/packages/2d/textures-materials/sky/skybox-volume-2-nebula-3392).

10. Textures folder: contains **8** textures, including **Floor texture**, **StartFinish texture** and so on.

11. Unity-chan! folder: contains the character we need in this game demo. Download from the Unity Asset Store, you can download them [here](https://assetstore.unity.com/packages/3d/characters/unity-chan-model-18705).

## Maintainers

[@Yunxiang-Li](https://github.com/Yunxiang-Li).

## License

[MIT license](https://github.com/Yunxiang-Li/Unity2D_A-Simple-Notepad-App/blob/master/LICENSE)
