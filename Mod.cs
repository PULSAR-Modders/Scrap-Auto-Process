using PulsarModLoader;

namespace Scrap_Auto_Process
{
    public class Mod : PulsarMod
    {
        public override string Version => "0.0.0";

        public override string Author => "18107";

        public override string ShortDescription => "Automatically process scrap as soon as it is collected or purchased";

        public override string Name => "Scrap Auto Process";

        public override string ModID => "scrapautoprocess";

        public override string HarmonyIdentifier()
        {
            return "id107.scrapautoprocess";
        }
    }
}
