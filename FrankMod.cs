using BepInEx;
using HarmonyLib;

namespace FrankMod
{
    [BepInPlugin("com.github.cdietschrun.FrankMod", "My name is Frank", "1.0.0")]

    public class FrankMod : BaseUnityPlugin
    {
        private void Awake()
        {
            var harmony = new Harmony("com.github.cdietschrun.FrankMod");
            harmony.PatchAll();
        }
    }
}
