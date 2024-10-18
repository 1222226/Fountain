### DECO3801/7381 Design Computing Studio 3 - Build Semester 2, 2024 
## Project: Hight Perception
## Team Members: 

1. [Introduction]
    Our project, "Height Perception," is designed to provide users with a unique visual experience of different heights in a virtual reality (VR) setting. Through seamless transitions and a high-quality VR environment, we ensure users feel comfortable while exploring. The project emphasizes intuitive user interfaces and safety features to minimize potential discomfort in VR.
To add an element of fun, we crafted the project as a challenging VR adventure game. Players experience height changes as part of the gameplay, solving puzzles and unlocking paths by adjusting their character's size using special props. Set in a vivid cartoon-style room, each level offers fresh challenges, combining exploration and interactivity. This design enhances the core functionality while keeping users curious and engaged, delivering an immersive and rewarding experience.
2. [Installation]
    This project is build in Unity. To view the code space, you can install Unity. When you open Unity Hub, first create a new project, choose the 3D build-in Render PipwLine. The version is 2022.3.8. After you enter,
   drag and import 7381.unity packge into the asserts(which looks like a unity logo). Then, go to the File(your project name)->packages, replace the manifest.josn file with the one we provided. Then the systm would
   automaticly download the packages. After that, you candrag MyScene from Asserts->Secene inyo the Hierarchy and remove the default scene. Finally, you can run the code. You are recommend to connect to an Oculus
   VR headset to view it by using Oculus Shift Link.  You may also use Meta Simulator(Click Meta-Meta-XR-Simulator=active), but the effect is not garanteed. 
4. [Usage]
    Use VR controllers to control.
    Rotate both hands of joysticks to move
    Press the joysticks to accellerate(Disabled in slow mode)
    Press Index button(both hands enable) to interact with UI
    Press Right Trigger Button to grab items(puzzle pieces, potiosns). You have to continues press it to grab.
    Press Buttom A while grabbing to collect items into backpack
    Press Button B to call/invisiable backpack
    Press Button X to transform the scale of player
    Press Left Trigger Button to jump.
6. [Features]
    Our project, "Height Perception," is designed to provide users with a unique visual experience of different heights in a virtual reality (VR) setting. Through seamless transitions and a high-quality VR environment, we ensure users feel comfortable while exploring. The project emphasizes intuitive user interfaces and safety features to minimize potential discomfort in VR.
To add an element of fun, we crafted the project as a challenging VR adventure game. Players experience height changes as part of the gameplay, solving puzzles and unlocking paths by adjusting their character's size using special props. Set in a vivid cartoon-style room, each level offers fresh challenges, combining exploration and interactivity. This design enhances the core functionality while keeping users curious and engaged, delivering an immersive and rewarding experience.
7. [DirectoryStructure]
    Here’s an overview of the project’s directory structure:
    projectname/
    │ 3
    ├── Asserts/
    │   ├── Scripts
             ├── ScaleTransform.cs
             ├── OVRPlayerControllerCustomize.cs
             ├── GameFlow.cs
             ├── Ball.cs
             ├── CameraFollow.cs
             ├── CollectPieces.cs
             ├── BackPack.cs
           
    │   └── Prefabs
    │   └── Materials
    │   └── Scenes
            │   └── MyScene
            │   └── MyScene2
    │   └── Source imported
    │   └── ...
   
    │
    ├── packges
    │   ├── ...
    │   └── ...
    └── README.md         # xxxx
8. [Contributing] 
# If applicable
    Invite others to contribute and explain how they can do so.
7. [License]
    This project is licensed under the [MIT License](link to license) - see the LICENSE file for details.
8. [Changelog]
# If applicable
    Keep track of version history and updates in this section to inform users of changes made.
9. [Contact] 
    For any questions or support, please contact:
    - Your Name - your.email@example.com
    - [GitHub Profile](link to profile)
