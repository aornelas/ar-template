# AR Template
An AR starter project with Vuforia imported and some performance optimizations.

#### Project includes:
* Standard `.gitignore`
* Unity project with ARCamera (Vuforia)
* AR performance optimizations (see below)

## AR Performance Optimizations
The AR performance optimizations included in this project were based on the talk _[Mobile AR: Simple Optimizations to Improve Thermal Conditions and Conserve Battery Life](https://mobilearsimpleoptimizationstoc.splashthat.com/?em=537)_ by [Adam Smith](linkedin.com/in/adam-smith-655b37a) (from [Unity at GDC 2018](https://unity3d.com/gdc-2018)).

The following optiomization were recommended in the talk (and applied to this project):
* Limit application framerate to 30fps [[390608b](https://github.com/aornelas/ar-template/commit/390608b267bff2aa266c990505397e614eb9d242)]
* Limit physics timestep to 0.0334 [[6f7b5ae](https://github.com/aornelas/ar-template/commit/6f7b5aeaf659a2b0a9bdea5fdfbcc7cc53b0e002)]
* Cut screen resolition in half [[948d0b8](https://github.com/aornelas/ar-template/commit/948d0b849d785f07e7cc5071e521a59652abebbb)]

#### Raw notes from the talk:
![notes](https://github.com/aornelas/ar-template/blob/master/Images/ARPerformance-notes.jpg?raw=true)
