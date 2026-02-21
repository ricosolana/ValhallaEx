using BepInEx;
//using Jotunn.Utils;
//using Logger = Jotunn.Logger;

namespace AvlCommand
{
    [BepInPlugin(ModGUID, ModName, ModVersion)]
    //[BepInDependency(Jotunn.Main.ModGuid)]
    public class Plugin : BaseUnityPlugin
    {
        public const string ModGUID = "com.crzi.avlcommand";
        public const string ModName = "AvlCommand";
        public const string ModVersion = "1.0.0";

        private void Awake()
        {
            //Logger.LogInfo("AvlCommand loaded successfully.");
        }
    }
}