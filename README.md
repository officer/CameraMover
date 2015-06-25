# CameraMover
CameraMover is a C# library of manipulating camera in Unity.

# Getting Started
Download this project as a zip, and extract it.
Then, Import *CameraMover.unitypackage* to your project.


# Usage

Write a code below.

`CameraManager.RegisterCameraMoveEvent(toPosition, toRotation)`

If you want to move camera gradually.
Write this.

`CameraManager.RegisterCameraMoveEvent(toPosition, toRotation, CameraMovementType.Lerp)`

or 

`CameraManager.RegisterCameraMoveEvent(toPosition, toRotation, CameraMovementType.Slerp)`



