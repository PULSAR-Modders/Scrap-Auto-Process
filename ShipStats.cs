using HarmonyLib;

namespace Scrap_Auto_Process
{
    [HarmonyPatch(typeof(PLShipStats), "AddShipComponent")]
    internal class ShipStats
    {
        static void Postfix(PLShipStats __instance, PLShipComponent inComponent)
        {
            if (__instance.Ship != PLEncounterManager.Instance.PlayerShip || !(inComponent is PLScrapCargo) || !PhotonNetwork.isMasterClient) return;

            PLServer.Instance.GetCachedFriendlyPlayerOfClass(0).photonView.RPC("AttemptToProcessScrapCargo", PhotonTargets.MasterClient, new object[]
                    {
                        __instance.Ship.ShipID,
                        inComponent.NetID
                    });
        }
    }
}
