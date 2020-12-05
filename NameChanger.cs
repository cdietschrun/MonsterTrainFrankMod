using HarmonyLib;

namespace FrankMod
{
    [HarmonyPatch(typeof(CharacterData))]
    [HarmonyPatch("GetName")]
    public static class NameChangerFrank
    {
        private static void Postfix(ref string __result)
        {
            if (__result == "Hornbreaker Prince")
            {
                __result = "Frank";
            }
        }
    }

    [HarmonyPatch(typeof(CardState))]
    [HarmonyPatch("GetTitle")]
    public static class NameChangerFrankCard
    {
        private static void Postfix(ref string __result)
        {
            if (__result == "Hornbreaker Prince")
            {
                __result = "Frank";
            }
        }
    }
}
