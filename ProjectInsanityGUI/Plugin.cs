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

namespace Qutan
{
    [BepInPlugin("zxcv.notif.hunt", "Hunt Watch Notifiation Libary", "1.0.0")]
    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {
            new Harmony("zxcv.notif.hunt").PatchAll(Assembly.GetExecutingAssembly());
        }


    }
}