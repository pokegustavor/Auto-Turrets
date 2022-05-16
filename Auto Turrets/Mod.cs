using PulsarModLoader;
namespace Extra_Auto_Turrets
{
    public class Mod : PulsarMod
    {
        public override string Version => "1.1";

        public override string Author => "pokegustavo";

        public override string ShortDescription => "Adds auto turret to all ships";

        public override string Name => "Extra Auto Turrets";


        public override string HarmonyIdentifier()
        {
            return "pokegustavo.ExtraAutoTurrets";
        }
    }
}
