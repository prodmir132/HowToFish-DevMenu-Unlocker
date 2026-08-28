using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BepInEx;
using HarmonyLib;
using UnityEngine;

namespace DevCheats
{

    [BepInPlugin("com.myname.repocheat", "Cheats", "1.0.0")]
    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        {
            var harmony = new Harmony("com.myname.repocheat");
            harmony.PatchAll();
            Logger.LogInfo("Cheats ready");
        }
    }

        [HarmonyPatch(typeof(SteamManager), "get_IsDev")]
    public class PretendDevPatch
    {
        [HarmonyPostfix]
        static void Postfix(ref bool __result)
        {
            __result = true;
        }
    }

}
