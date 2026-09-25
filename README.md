# Marker Based AR

基于 Unity AR Foundation 的图像标记 AR 项目。摄像头识别指定图片后，在标记位置显示并持续旋转 3D 模型。

## 功能

- 使用 `ARTrackedImageManager` 识别图片标记
- 在识别到的标记上生成 SpongeBob 模型
- 模型围绕世界坐标 Y 轴自动旋转
- 支持 Android ARCore 和 iOS ARKit

## 环境

- Unity `6000.3.24f1`
- AR Foundation `6.3.5`
- ARCore XR Plugin `6.3.5`
- ARKit XR Plugin `6.3.5`
- Input System `1.20.0`

## 运行

1. 使用 Unity Hub 打开项目。
2. 打开 `Assets/MainScene.unity`。
3. 在支持 ARCore 或 ARKit 的真机上构建并运行。
4. 将摄像头对准项目配置的参考图片，模型会出现在图片位置。

参考图片位于 `Assets/Materials/marker_1.jpg`，图像库配置位于 `Assets/MyMarkers.asset`。

## 主要文件

- `Assets/MainScene.unity`：AR 主场景
- `Assets/Prefabs/SpawnedObject.prefab`：识别后生成的模型预制体
- `Assets/Scripts/SpinObjectOnMarker.cs`：模型旋转逻辑
- `Assets/MyMarkers.asset`：参考图像库

