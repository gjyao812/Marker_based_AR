# Marker Based AR

An image tracking AR project built with Unity AR Foundation. When the camera recognizes the configured reference image, a rotating 3D model appears on the marker.

## Features

- Tracks an image marker with `ARTrackedImageManager`
- Spawns a SpongeBob model on the detected marker
- Rotates the model around the world Y axis
- Supports Android with ARCore and iOS with ARKit

## Requirements

- Unity `6000.3.24f1`
- AR Foundation `6.3.5`
- ARCore XR Plugin `6.3.5`
- ARKit XR Plugin `6.3.5`
- Input System `1.20.0`

## Run the Project

1. Open the project in Unity Hub.
2. Open `Assets/MainScene.unity`.
3. Build and run on an ARCore or ARKit compatible device.
4. Point the camera at the configured reference image. The model will appear on the marker.

The reference image is stored at `Assets/Materials/marker_1.jpg`. The image library is configured in `Assets/MyMarkers.asset`.

## Main Files

- `Assets/MainScene.unity`: Main AR scene
- `Assets/Prefabs/SpawnedObject.prefab`: Model spawned after image detection
- `Assets/Scripts/SpinObjectOnMarker.cs`: Model rotation logic
- `Assets/MyMarkers.asset`: Reference image library

