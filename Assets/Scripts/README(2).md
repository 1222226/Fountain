### DECO3801/7381 Design Computing Studio 3 - Build Semester 2, 2024 
## Project: Hight Perception
## Team Members: 

1. [Introduction]
    Our project, "Height Perception," is designed to provide users with a unique visual experience of different heights in a virtual reality (VR) setting. Through seamless transitions and a high-quality VR environment, we ensure users feel comfortable while exploring. The project emphasizes intuitive user interfaces and safety features to minimize potential discomfort in VR.
To add an element of fun, we crafted the project as a challenging VR adventure game. Players experience height changes as part of the gameplay, solving puzzles and unlocking paths by adjusting their character's size using special props. Set in a vivid cartoon-style room, each level offers fresh challenges, combining exploration and interactivity. This design enhances the core functionality while keeping users curious and engaged, delivering an immersive and rewarding experience.
    Our project, "Height Perception," is designed to provide users with a unique visual experience of different heights in a virtual reality (VR) setting. Through seamless transitions and a high-quality VR environment, we ensure users feel comfortable while exploring. The project emphasizes intuitive user interfaces and safety features to minimize potential discomfort in VR.
    To add an element of fun, we crafted the project as a challenging VR adventure game. Players experience height changes as part of the gameplay, solving puzzles and unlocking paths by adjusting their character's size using special props. Set in a vivid cartoon-style room, each level offers fresh challenges, combining exploration and interactivity. This design enhances the core functionality while keeping users curious and engaged, delivering an immersive and rewarding experience.
2. [Installation]
    This project is build in Unity. To view the code space, you can install Unity. When you open Unity Hub, first create a new project, choose the 3D build-in Render PipeLine. The version is 2022.3.8. After you enter,
   drag and import 7381.unity packge into the asserts(which looks like a unity logo). Then, go to the File(your project name)->packages, replace the manifest.josn file with the one we provided. Then the systm would
   automaticly download the packages. After that, you candrag MyScene from Asserts->Secene inyo the Hierarchy and remove the default scene. Finally, you can run the code. You are recommend to connect to an Oculus
   VR headset to view it by using Oculus Shift Link.  You may also use Meta Simulator(Click Meta-Meta-XR-Simulator=active), but the effect is not garanteed. 
3. [Usage]
    Use VR controllers to control.
    Rotate both hands of joysticks to move
    Press the joysticks to accellerate(Disabled in slow mode)
    Press Index button(both hands enable) to interact with UI
    Press Right Trigger Button to grab items(puzzle pieces, potiosns). You have to continues press it to grab.
    Press Buttom A while grabbing to collect items into backpack
    Press Button B to call/invisiable backpack
    Press Button X to transform the scale of player
    Press Left Trigger Button to jump.
4. [Features]
·Seamless Transition Height Change: The prototype allows players to change their size by interacting with game props like potions. Height transitions are smooth, preventing motion sickness and ensuring a natural experience.
·Cartoon-style Virtual Scene: We built a cartoon-style dungeon scene where users can explore different visual effects and pass through the game levels we designed through height changes.
·Advanced Interactive Features: Key interactive objects like treasure chests, doors, and gears use animations to enhance the gameplay experience. Players can interact with these objects, which respond based on their size and actions.
·Advanced Interactive Features:Level Interaction and Traps: Various traps, such as rotating gears and swinging swords, challenge players to strategically adjust their size to progress. Collecting keys and unlocking doors adds complexity to the level design.
·Jump and Haptic Feedback: The jump mechanic varies according to the player's size, and planned haptic feedback will provide physical sensations during object interactions.
·Manual Interaction and Puzzle Mechanics: Players can manually grab and manipulate objects in the VR environment. Puzzle pieces can be placed on a board, with real-time feedback enhancing interactivity.
5. [DirectoryStructure]
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

6. [License]
The assets used in this project are subject to the Unity Asset Store End User License Agreement (EULA). Please refer to the [Unity Asset Store Terms](https://unity3d.com/legal/as_terms) for more details.


7. [Contact] 
    For any questions or support, please contact:
    - wang liao - w.liao1@student.uq.edu.au
    - [GitHub Profile](https://github.com/1222226/Fountain)
