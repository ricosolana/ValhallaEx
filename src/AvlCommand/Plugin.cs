using BepInEx;
using Jotunn.Utils;
using UnityEngine;

namespace AvlCommand
{
    [BepInPlugin(ModGUID, ModName, ModVersion)]
    public class Plugin : BaseUnityPlugin
    {
        public const string ModGUID = "com.crzi.avlcommand";
        public const string ModName = "AvlCommand";
        public const string ModVersion = "1.0.0";

        private void Awake()
        {
            Logger.LogInfo("AvlCommand loaded successfully.");
        }
    }
}