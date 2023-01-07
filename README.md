# Gorilla-Tag-Hunt-Watch-Notification-Library
A notification library that allows utilization of the hunt watch to show notifications.

It may take up 10 seconds for the watch to load

# How to use the libary
1. First of all you need to a add a project reference to the dll in order for it to work
2. Add the hunt watch notification libary into ur plugins
3. Once your finished with that you will need to add a BepInDependency so it works you can do this using
[BepInDependency("zxcv.notif.hunt")]
4. Send a notification using
HuntNotif.SendNotification("coolthing");

# Exmaple Code
```csharp
using BepInEx;
using ExitGames.Client.Photon;
using GorillaLocomotion;
using GorillaNetworking;
using HarmonyLib;
using Photon.Pun;
using Photon.Pun.UtilityScripts;
using Photon.Realtime;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using UnityEngine;

namespace ExampleCode
{
    [BepInPlugin("Exmaple.Code.Here", "Temp", "1.0.0")]
    [BepInDependency("zxcv.notif.hunt")]
    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {
            new Harmony("Example.Code.Here").PatchAll(Assembly.GetExecutingAssembly());
            HuntNotif.SendNotification("coolthing");
        }
    } 
}
```
