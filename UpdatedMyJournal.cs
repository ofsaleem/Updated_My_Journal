using HarmonyLib;
using XRL.World; // for GameObject

namespace Mods.UpdatedMyJournal
{
    [HarmonyPatch(typeof(Qud.API.IBaseJournalEntry))]
    class UpdatedMyJournal
    {
        [HarmonyPatch("Reveal")]
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