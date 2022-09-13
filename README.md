# ALAAARM <img src="./ALAAARM.png" align="center" width="50">
Alarm clock!

Simple Windows Forms application what creates alarm clocks.

![App look](https://user-images.githubusercontent.com/71507444/189630600-ebc680dc-5e51-4147-a836-ad37355b06f4.png)


## Features
* Relatvie/direct time usage
* Management of working alarms
* Custom alarm sounds
* [Addons](#addons)
* Minimization to tray (WIP)

## Addons
Want to create addon for alAAARM? Okay! Follow this guide:
1. Create DLL .NET Framework 4.8 project.
2. Add references to:
  * alAAARM.alAAARM (from executable)
  * System.Windows.Forms
3. Create class named `Addon` (be sure to call it exactly that) and derived from alAAARM.Addon.
4. Do what you want.
5. Build project.
6. Put output DLL file to `addons` folder in alAAARM directory, or directly add it (for now it won't remember DLL path).

<details>
  <summary></summary>
  first version done in one hour and improved after five hours of coding and another hour of debugging, lol
  
  ![how long](https://user-images.githubusercontent.com/71507444/189475493-2ac2c7a5-8682-4109-b258-8c7c66e577db.png)
</details>
