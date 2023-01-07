using ExitGames.Client.Photon;
using GorillaNetworking;
using Photon.Pun;
using Photon.Realtime;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using UnityEngine;
using UnityEngine.XR;
using HarmonyLib;
using System.Threading.Tasks;
using Qutan;

namespace Qutan.LoadingMenu
{
    public class LoadWatch 
    {
        [HarmonyPatch(typeof(GorillaLocomotion.Player))]
        [HarmonyPatch("FixedUpdate", MethodType.Normal)]
        internal class Hunt
        {
            private static async void Prefix()
            {
                if (!first)
                {
                    await Task.Delay(10000);
                    first = true;
                }

                VRRig myRig = GameObject.Find("Global/Local VRRig/Local Gorilla Player").GetComponent<VRRig>();
                GameObject huntComputer = myRig.huntComputer;
                huntComputer.SetActive(true);
                GorillaHuntComputer gorillaHuntComputer = huntComputer.GetComponent<GorillaHuntComputer>();
                gorillaHuntComputer.text.text = Config.CurrentNotif;
                gorillaHuntComputer.material.gameObject.SetActive(false);
                gorillaHuntComputer.hat.gameObject.SetActive(false);
                gorillaHuntComputer.face.gameObject.SetActive(false);
                gorillaHuntComputer.badge.gameObject.SetActive(false);
                gorillaHuntComputer.leftHand.gameObject.SetActive(false);
                gorillaHuntComputer.rightHand.gameObject.SetActive(false);
            }
        }
        public static bool first = false;
    }
}
