using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using XRL.Rules;
using XRL.World; // for GameObject
using XRL.World.Effects;

namespace Mods.UpdatedMyJournal
{
    [HarmonyPatch(typeof(XRL.Messages.MessageQueue))]
    class UpdatedMyJournal
    {
        [HarmonyPrefix]
        [HarmonyPatch("Add")]
        static void Prefix(ref string Message)
        {
            Message = "{{chaotic|" + Message + "}}";
        }

        private static void PlaySound(GameObject obj)
        {
            obj.PlayWorldSound("updated-my-journal");
        }
    }
}