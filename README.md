# EnaKit.UI

## UICore

抽象出来的核心代码。

### 设计概念

1. 数据与 UI 分离，布局暂时由 NewtonSoft.Json 序列化，以 Group 为一组存储和加载。
2. 核心卖点为 Runtime 下的编辑器功能，内置动画，可以轻松的开发在 UGC 游戏。
3. 当然屏幕自适应和各种布局锚点也是基本的。
4. 多语言也会有的……暂时叫多态系统，可以中英文切换时响应变更，更可以切 R18 时实时响应 UI 变更！
5. element 与 component 分离，支持随意的定义 element。

### component

event

1. click
2. touches
3. drag
4. drop

render

1. text
2. image
3. sound
4. video

anime

1. fade

### element

1. Text
2. TextInput
3. Image
4. Video
5. Button
6. Loader
7. Loader3D
8. Window
9. List
10. Tree
11. Graph
12. Joystick

## UIRuntime

运行时代码。

## UIEditor

编辑器代码（不是 Unity 的那个编辑器）。

## UIUnity

由 EnaKit.UI 去驱动 UGUI 去运行，此为驱动 UGUI 运行的代码。