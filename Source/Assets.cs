using System.IO;
using HarmonyLib;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.AddressableAssets;

namespace Nyxpiri.ULTRAKILL.MundaneMurder
{
    public static class Assets
    {
        public static Texture2D MundaneMurderIcon { get; private set; } = null;

        public static void Initialize()
        {
            Log.Debug($"Assets.Initialize called!");
            var modsDir = BepInEx.Paths.PluginPath;
            var assetsDir = $"{modsDir}/mundanemurder_assets";
            Log.Debug($"Loading assets in {assetsDir}!");
            
            MundaneMurderIcon = LoadTexture($"{assetsDir}/mundane_murder.png");
        }

        private static Texture2D LoadTexture(string path)
        {
            Log.Debug($"Attempting to load texture from '{path}'");
            var fileBytes = File.ReadAllBytes(path);
            var texture = new Texture2D(1, 1);
            
            if (fileBytes != null)
            {
                try
                {
                    if (!ImageConversion.LoadImage(texture, fileBytes))
                    {
                        Log.Error($"Failed to load asset '{path}'");
                    }   
                }
                catch (System.Exception e)
                {
                    Log.Error($"Failed to load asset '{path}' error/exception: {e}");
                    texture = new Texture2D(1, 1);
                }
            }

            Log.Debug($"Seemingly successfully loaded asset at '{path}'");
            return texture;
        }
    }
}