# Unity Interactive 3D Scene

**Computer Graphics Lab 9 — Create a simple interactive 3D scene using Unity.**

This project demonstrates a complete interactive 3D scene built in Unity. The scene contains a controllable player, jumping and gravity, obstacles, animated objects, collectibles, lighting, a smooth follow camera, and an on-screen HUD.

## Features

- 3D player movement using **WASD / Arrow Keys**
- **Space** to jump
- CharacterController-based movement and gravity
- Smooth third-person follow camera
- Ground and multiple 3D obstacles
- Continuously rotating 3D objects
- Collectible objects with score tracking
- Directional lighting and generated materials
- Runtime HUD showing controls and score
- Scene is generated automatically on first project import

## Controls

| Key | Action |
| --- | --- |
| W / Up Arrow | Move forward |
| S / Down Arrow | Move backward |
| A / Left Arrow | Move left |
| D / Right Arrow | Move right |
| Space | Jump |
| R | Reset player position |
| Esc | Quit build |

## Project Structure

```text
Assets/
├── Editor/
│   └── LabSceneAutoSetup.cs
└── Scripts/
    ├── CameraFollow.cs
    ├── Collectible.cs
    ├── GameHUD.cs
    ├── PlayerController.cs
    └── RotatingObject.cs
Packages/
└── manifest.json
ProjectSettings/
└── ProjectVersion.txt
```

## Automatic Scene Setup

When the project is opened in Unity for the first time, `LabSceneAutoSetup.cs` automatically creates and saves:

```text
Assets/Scenes/Lab9_Interactive3DScene.unity
```

The generated scene includes the player, ground, obstacles, rotating objects, collectibles, lighting, camera, and HUD. It is also added automatically to the Build Settings.

## How to Run

1. Clone or download this repository.
2. Open the project folder from **Unity Hub**.
3. Wait for Unity to finish importing and compiling scripts.
4. The lab scene is generated automatically.
5. Open `Assets/Scenes/Lab9_Interactive3DScene.unity` if it is not already open.
6. Press **Play**.

## Concepts Demonstrated

This lab demonstrates important fundamentals of interactive 3D graphics:

- 3D coordinate systems and transformations
- Real-time player interaction
- Camera positioning and tracking
- Collision and character movement
- Lighting in a 3D environment
- Object animation
- Scene composition
- Game loop based real-time updates

## Result

A functional interactive 3D scene was successfully developed in Unity. The user can move and jump through the environment, interact with collectibles, navigate around obstacles, and observe animated 3D objects while the camera follows the player smoothly.
