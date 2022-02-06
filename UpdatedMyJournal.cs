using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using XRL.Rules;
using XRL.World; // for GameObject
using XRL.World.Effects;

namespace Mods.UpdatedMyJournal
{
    [HarmonyPatch(typeof(Qud.API.JournalAPI))]
    class UpdatedMyJournal
    {
        [HarmonyPrefix]
        [HarmonyPatch("AddAccomplishments")]
        static void Postfix(ref string Message)
        {
            Message = "{{chaotic|" + Message + "}}";
        }

        private static void PlaySound(GameObject obj)
        {
            obj.PlayWorldSound("updated-my-journal");
        }
    }
}