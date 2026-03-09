using UnityEngine;
using BepInEx;

namespace Nyxpiri.ULTRAKILL.MundaneMurder
{
    [BepInPlugin("com.nyxpiri.bepinex.plugins.ultrakill.mundane-murder", "Mundane Murder", "0.0.0.1")]
    [BepInProcess("ULTRAKILL.exe")]
    public class MundaneMurderPlugin : BaseUnityPlugin
    {
        protected void Awake()
        {
            Log.Initialize(Logger);
            MundaneMurder.Initialize();
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
