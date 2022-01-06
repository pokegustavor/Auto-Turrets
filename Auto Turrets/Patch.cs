using HarmonyLib;
using UnityEngine;
using System.Collections.Generic;
namespace Extra_Auto_Turrets
{
    internal class Patch
    {
        [HarmonyPatch(typeof(PLIntrepidInfo), "SetupShipStats")]
        class Intrepid
        {
            static void Postfix(PLIntrepidInfo __instance, bool previewStats)
            {
                if (!previewStats)
                {
                    GameObject turretPoint = Object.Instantiate(__instance.RegularTurretPoints[0].gameObject, new Vector3((__instance.RegularTurretPoints[0].transform.position.x + __instance.RegularTurretPoints[1].transform.position.x) / 2, __instance.RegularTurretPoints[0].transform.position.y, __instance.RegularTurretPoints[0].transform.position.z + (__instance.RegularTurretPoints[0].transform.forward * 1.25f).z), new Quaternion(__instance.RegularTurretPoints[0].rotation.x, __instance.RegularTurretPoints[0].rotation.y, __instance.RegularTurretPoints[0].rotation.z, __instance.RegularTurretPoints[0].rotation.w));
                    turretPoint.transform.SetParent(__instance.Exterior.transform);
                    Transform[] newAutoTurret = new Transform[2];
                    newAutoTurret[0] = turretPoint.transform;
                    GameObject turretPoint2 = Object.Instantiate(__instance.RegularTurretPoints[0].gameObject, new Vector3((__instance.RegularTurretPoints[0].transform.position.x + __instance.RegularTurretPoints[1].transform.position.x) / 2, __instance.RegularTurretPoints[0].transform.position.y, __instance.RegularTurretPoints[0].transform.position.z - (__instance.RegularTurretPoints[0].transform.forward * 1.75f).z), new Quaternion(__instance.RegularTurretPoints[0].rotation.x, __instance.RegularTurretPoints[0].rotation.y, __instance.RegularTurretPoints[0].rotation.z, __instance.RegularTurretPoints[0].rotation.w));
                    turretPoint2.transform.SetParent(__instance.Exterior.transform);
                    newAutoTurret[1] = turretPoint2.transform;
                    __instance.AutoTurretPoints = newAutoTurret;
                    __instance.MyStats.SetSlotLimit(ESlotType.E_COMP_AUTO_TURRET, 2);
                }
            }
        }
        [HarmonyPatch(typeof(PLOutriderInfo), "SetupShipStats")]
        class Outrider
        {
            static void Postfix(PLOutriderInfo __instance, bool previewStats)
            {
                if (!previewStats)
                {
                    GameObject turretPoint = Object.Instantiate(__instance.RegularTurretPoints[0].gameObject, new Vector3(__instance.MainTurretPoint.transform.position.x + (__instance.MainTurretPoint.transform.right * 1.35f).x, __instance.MainTurretPoint.transform.position.y, __instance.MainTurretPoint.transform.position.z), new Quaternion(__instance.MainTurretPoint.rotation.x, __instance.MainTurretPoint.rotation.y, __instance.MainTurretPoint.rotation.z, __instance.MainTurretPoint.rotation.w));
                    turretPoint.transform.SetParent(__instance.Exterior.transform);
                    Transform[] newAutoTurret = new Transform[2];
                    newAutoTurret[0] = turretPoint.transform;
                    GameObject turretPoint2 = Object.Instantiate(__instance.RegularTurretPoints[0].gameObject, new Vector3(__instance.MainTurretPoint.transform.position.x - (__instance.MainTurretPoint.transform.right * 1.35f).x, __instance.MainTurretPoint.transform.position.y, __instance.MainTurretPoint.transform.position.z), new Quaternion(__instance.MainTurretPoint.rotation.x, __instance.MainTurretPoint.rotation.y, __instance.MainTurretPoint.rotation.z, __instance.MainTurretPoint.rotation.w));
                    turretPoint2.transform.SetParent(__instance.Exterior.transform);
                    newAutoTurret[1] = turretPoint2.transform;
                    __instance.AutoTurretPoints = newAutoTurret;
                    __instance.MyStats.SetSlotLimit(ESlotType.E_COMP_AUTO_TURRET, 2);
                }
            }
        }
        [HarmonyPatch(typeof(PLCruiserInfo), "SetupShipStats")]
        class Cruiser
        {
            static void Postfix(PLCruiserInfo __instance, bool previewStats)
            {
                if (!previewStats)
                {
                    GameObject turretPoint = Object.Instantiate(__instance.RegularTurretPoints[0].gameObject, new Vector3(__instance.RegularTurretPoints[0].transform.position.x, __instance.RegularTurretPoints[0].transform.position.y, __instance.RegularTurretPoints[0].transform.position.z - (__instance.RegularTurretPoints[0].transform.forward * 5.8f).z), new Quaternion(__instance.RegularTurretPoints[0].rotation.x, __instance.RegularTurretPoints[0].rotation.y, __instance.RegularTurretPoints[0].rotation.z, __instance.RegularTurretPoints[0].rotation.w));
                    turretPoint.transform.SetParent(__instance.Exterior.transform);
                    Transform[] newAutoTurret = new Transform[2];
                    newAutoTurret[0] = turretPoint.transform;
                    GameObject turretPoint2 = Object.Instantiate(__instance.RegularTurretPoints[1].gameObject, new Vector3(__instance.RegularTurretPoints[1].transform.position.x, __instance.RegularTurretPoints[1].transform.position.y, __instance.RegularTurretPoints[1].transform.position.z - (__instance.RegularTurretPoints[1].transform.forward * 5.8f).z), new Quaternion(__instance.RegularTurretPoints[1].rotation.x, __instance.RegularTurretPoints[1].rotation.y, __instance.RegularTurretPoints[1].rotation.z, __instance.RegularTurretPoints[1].rotation.w));
                    turretPoint2.transform.SetParent(__instance.Exterior.transform);
                    newAutoTurret[1] = turretPoint2.transform;
                    __instance.AutoTurretPoints = newAutoTurret;
                    __instance.MyStats.SetSlotLimit(ESlotType.E_COMP_AUTO_TURRET, 2);
                }
            }
        }
    }
}