using System;
using System.Collections.Generic;
using System.Text;
using HarmonyLib;

namespace Qutan.Patches
{
    internal class PatchToFix
    {
        [HarmonyPatch(typeof(GorillaHuntComputer))]
        [HarmonyPatch("Update", MethodType.Normal)]
        internal class stopChange
        {
            private static bool Prefix()
            {
                return false;
            }
        }
    }
}
