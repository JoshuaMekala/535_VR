# 535_VR
**Motivation:** The team’s motivation for doing this project was first to work on a project that was interesting, and incorporated VR. The three members of this team are also on a Senior Design Project team together, and found this project closely lined up with our own SDP project. In hopes of meshing these two projects together, we have decided to do this project. 

**Design Goals:**  The first design goal of this project is to stream the panoramic view of a physical space from a 360-camera to a VR headset. The second design goal is to overlay virtual objects on the 360 camera stream. 

**Deliverables:**
 Configure the 360-camera to live stream a physical space.
Attach a tracker to a physical object and attach a virtual augmentation to its corresponding view.
 Track the virtual object when its physical counterpart moves.

**Block Diagram:**

**Hardware Requirements:** Ricoh Theta Z1, HTC vive cosmos elite VR headset, vive trackers

**Software Requirements:**  
Ricoh Theta UVC driver 
  - for usb streaming to PC and VR 
Unity
  - Environment to stream the 360 camera. 
SteamVR plugin/SDK
  - Utilizes necessary plugins.
Virtual Reality Toolkit for Unity 
  - Allows VR development to work in Unity
Skybox shaders
  - Renders the 360 livestream into a video that can then be displayed to the VR user. 
Vive Tracker Utility
  - Allows the user to utilize the vive trackers, and place VR objects on the tracker. 


Team Members responsibilities:

Josh (Video setup and Capture Lead):
Stream the 360-video from the Ricoh Theta Z1 to the HTC Vive.
Find the lowest latency method of actually streaming it, whether that be through USB, or WiFi. 
Assist with the vive tracker/virtual object creation/overlay.

John (Unity and VR overlay lead):
Setup the VR environment in Unity
Map the 360 video to the Unity environment utilizing Skybox shaders.
Assist with the vive tracker/virtual object creation/overlay.

Cam (Object Tracking and Interaction Lead):
Set up to track physical objects with Vive Trackers. 
Ensure the virtual objects are synced with the real-world objects. 

Project timeline: 

References:

How to make a 360 environment in Unity: https://www.youtube.com/watch?v=eaqwszsH6Jg

Augmented Virtual Teleportation for High-Fidelity Telecollaboration: https://ieeexplore.ieee.org/stamp/stamp.jsp?tp=&arnumber=8998353

SCeVE: A Component-based Framework to Author Mixed Reality Tours: https://dl.acm.org/doi/pdf/10.1145/3377353

Exploring interaction techniques for 360 panoramas inside a 3D reconstructed scene for mixed reality remote collaboration (Journal on Multimodal User Interfaces-2020): https://link.springer.com/article/10.1007/s12193-020-00343-x

