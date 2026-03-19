using UnityEngine;
using BepInEx;
using System;
using System.IO;

namespace Nyxpiri.ULTRAKILL.MundaneMurder
{
    public static class Cheats
    {
        public const string MundaneMurder = "nyxpiri.mundane-murder";
    }

    [BepInPlugin("nyxpiri.ultrakill.mundane-murder", "Mundane Murder", "0.0.0.1")]
    [BepInProcess("ULTRAKILL.exe")]
    public class MundaneMurderPlugin : BaseUnityPlugin
    {
        protected void Awake()
        {
            Log.Initialize(Logger);
            MundaneMurder.Initialize();
            NyxLib.Cheats.ReadyForCheatRegistration += RegisterCheats;
            
            if (!File.Exists(Config.ConfigFilePath))
            {
                Config.Save();
            }
        }

        private void RegisterCheats(CheatsManager cheatsManager)
        {
            cheatsManager.RegisterCheat(new ToggleCheat(
                "mundanemurder Mode", 
                Cheats.MundaneMurder,
                onDisable: (cheat) =>
                {
                },
                onEnable: (cheat, manager) =>
                {
                }
            ), "THIS GAME IF IT SUCKED:");
        }

        protected void Start()
        {
        }

        protected void Update()
        {

        }

        protected void LateUpdate()
        {

        }
    }
}
