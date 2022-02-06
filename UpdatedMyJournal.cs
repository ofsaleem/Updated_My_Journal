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
        [HarmonyPatch("AddAccomplishments")]
        [HarmonyPatch("AddGeneralNote")]
        [HarmonyPatch("AddMapNote")]
        [HarmonyPatch("AddObservation")]
        [HarmonyPatch("AddRecipeNote")]
        static void Postfix()
        {
            PlayJournalLine();
        }

        private static void PlayJournalLine()
        {
            IComponent<GameObject>.PlayUISound("updated-my-journal");
        }
    }
}