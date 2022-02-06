using HarmonyLib;
using XRL.World; // for GameObject

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