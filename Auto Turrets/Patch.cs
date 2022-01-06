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
        [HarmonyPatch(typeof(PLWDAnnihilatorInfo), "SetupShipStats")]
        class Annihilator
        {
            static void Postfix(PLWDAnnihilatorInfo __instance, bool previewStats)
            {
                if (!previewStats)
                {
                    GameObject turretPoint = Object.Instantiate(__instance.RegularTurretPoints[0].gameObject, new Vector3(__instance.RegularTurretPoints[1].transform.position.x + (__instance.RegularTurretPoints[1].transform.right * 2.64f).x, __instance.RegularTurretPoints[1].transform.position.y - (__instance.RegularTurretPoints[1].transform.up * 1.98f).y, __instance.RegularTurretPoints[1].transform.position.z - (__instance.RegularTurretPoints[0].transform.forward * 1.9f).z), new Quaternion(__instance.RegularTurretPoints[1].rotation.x, __instance.RegularTurretPoints[1].rotation.y, __instance.RegularTurretPoints[1].rotation.z + 1.7071f, __instance.RegularTurretPoints[1].rotation.w + 0.7071f));
                    turretPoint.transform.SetParent(__instance.Exterior.transform);
                    Transform[] newAutoTurret = new Transform[1];
                    newAutoTurret[0] = turretPoint.transform;
                    __instance.AutoTurretPoints = newAutoTurret;
                    __instance.MyStats.SetSlotLimit(ESlotType.E_COMP_AUTO_TURRET, 1);
                }
            }
        }
        [HarmonyPatch(typeof(PLStarGazerInfo), "SetupShipStats")]
        class StarGazer
        {
            static void Postfix(PLStarGazerInfo __instance, bool previewStats)
            {
                if (!previewStats)
                {
                    GameObject turretPoint = Object.Instantiate(__instance.RegularTurretPoints[0].gameObject, new Vector3(__instance.RegularTurretPoints[0].transform.position.x, __instance.RegularTurretPoints[0].transform.position.y - (__instance.RegularTurretPoints[0].transform.up * 0.134f).y, __instance.RegularTurretPoints[0].transform.position.z + (__instance.RegularTurretPoints[0].transform.forward * 1.29f).z), new Quaternion(__instance.RegularTurretPoints[0].rotation.x, __instance.RegularTurretPoints[0].rotation.y, __instance.RegularTurretPoints[0].rotation.z, __instance.RegularTurretPoints[0].rotation.w));
                    turretPoint.transform.SetParent(__instance.Exterior.transform);
                    Transform[] newAutoTurret = new Transform[2];
                    newAutoTurret[0] = turretPoint.transform;
                    GameObject turretPoint2 = Object.Instantiate(__instance.RegularTurretPoints[1].gameObject, new Vector3(__instance.RegularTurretPoints[1].transform.position.x, __instance.RegularTurretPoints[1].transform.position.y - (__instance.RegularTurretPoints[1].transform.up * 0.134f).y, __instance.RegularTurretPoints[1].transform.position.z + (__instance.RegularTurretPoints[1].transform.forward * 1.29f).z), new Quaternion(__instance.RegularTurretPoints[1].rotation.x, __instance.RegularTurretPoints[1].rotation.y, __instance.RegularTurretPoints[1].rotation.z, __instance.RegularTurretPoints[1].rotation.w));
                    turretPoint2.transform.SetParent(__instance.Exterior.transform);
                    newAutoTurret[1] = turretPoint2.transform;
                    __instance.AutoTurretPoints = newAutoTurret;
                    __instance.MyStats.SetSlotLimit(ESlotType.E_COMP_AUTO_TURRET, 2);
                }
            }
        }
        [HarmonyPatch(typeof(PLCarrierInfo), "SetupShipStats")]
        class Carrier
        {
            static void Postfix(PLCarrierInfo __instance, bool previewStats)
            {
                if (!previewStats)
                {
                    GameObject turretPoint = Object.Instantiate(__instance.RegularTurretPoints[0].gameObject, new Vector3(__instance.RegularTurretPoints[0].transform.position.x, __instance.RegularTurretPoints[0].transform.position.y - (__instance.RegularTurretPoints[0].transform.up * 0.46f).y, __instance.RegularTurretPoints[0].transform.position.z - (__instance.RegularTurretPoints[0].transform.forward * 4.64f).z), new Quaternion(__instance.RegularTurretPoints[0].rotation.x, __instance.RegularTurretPoints[0].rotation.y, __instance.RegularTurretPoints[0].rotation.z, __instance.RegularTurretPoints[0].rotation.w));
                    turretPoint.transform.SetParent(__instance.Exterior.transform);
                    Transform[] newAutoTurret = new Transform[3];
                    newAutoTurret[0] = turretPoint.transform;
                    GameObject turretPoint2 = Object.Instantiate(__instance.RegularTurretPoints[0].gameObject, new Vector3(__instance.RegularTurretPoints[0].transform.position.x - (__instance.RegularTurretPoints[0].transform.right * 4.1447f).x, __instance.RegularTurretPoints[0].transform.position.y - (__instance.RegularTurretPoints[0].transform.up * 0.3001f).y, __instance.RegularTurretPoints[0].transform.position.z - (__instance.RegularTurretPoints[0].transform.forward * 16.4799f).z), new Quaternion(__instance.RegularTurretPoints[0].rotation.x, __instance.RegularTurretPoints[0].rotation.y, __instance.RegularTurretPoints[0].rotation.z + 0.3827f, __instance.RegularTurretPoints[0].rotation.w - 0.0761f));
                    turretPoint2.transform.SetParent(__instance.Exterior.transform);
                    newAutoTurret[1] = turretPoint2.transform;
                    GameObject turretPoint3 = Object.Instantiate(__instance.RegularTurretPoints[0].gameObject, new Vector3(__instance.RegularTurretPoints[0].transform.position.x + (__instance.RegularTurretPoints[0].transform.right * 4.2399f).x, __instance.RegularTurretPoints[0].transform.position.y - (__instance.RegularTurretPoints[0].transform.up * 0.3001f).y, __instance.RegularTurretPoints[0].transform.position.z - (__instance.RegularTurretPoints[0].transform.forward * 16.4799f).z), new Quaternion(__instance.RegularTurretPoints[0].rotation.x, __instance.RegularTurretPoints[0].rotation.y, __instance.RegularTurretPoints[0].rotation.z - 0.3827f, __instance.RegularTurretPoints[0].rotation.w - 0.0761f));
                    turretPoint3.transform.SetParent(__instance.Exterior.transform);
                    newAutoTurret[2] = turretPoint3.transform;
                    __instance.AutoTurretPoints = newAutoTurret;
                    __instance.MyStats.SetSlotLimit(ESlotType.E_COMP_AUTO_TURRET, 3);
                }
            }
        }
        [HarmonyPatch(typeof(PLOldWarsShip_Sylvassi), "SetupShipStats")]
        class SwordShip
        {
            static void Postfix(PLOldWarsShip_Sylvassi __instance, bool previewStats)
            {
                if (!previewStats)
                {
                    GameObject turretPoint = Object.Instantiate(__instance.RegularTurretPoints[0].gameObject, new Vector3(__instance.RegularTurretPoints[0].transform.position.x - Mathf.Abs(__instance.RegularTurretPoints[0].transform.position.x - __instance.MainTurretPoint.transform.position.x) * 2, __instance.RegularTurretPoints[0].transform.position.y, __instance.RegularTurretPoints[0].transform.position.z), new Quaternion(__instance.RegularTurretPoints[0].rotation.x, __instance.RegularTurretPoints[0].rotation.y, __instance.RegularTurretPoints[0].rotation.z, __instance.RegularTurretPoints[0].rotation.w));
                    turretPoint.transform.SetParent(__instance.Exterior.transform);
                    Transform[] newAutoTurret = new Transform[1];
                    newAutoTurret[0] = turretPoint.transform;
                    __instance.AutoTurretPoints = newAutoTurret;
                    __instance.MyStats.SetSlotLimit(ESlotType.E_COMP_AUTO_TURRET, 1);
                }
            }
        }
    }
}