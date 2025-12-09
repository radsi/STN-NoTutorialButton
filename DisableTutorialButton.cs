using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HarmonyLib;
using System.Reflection;
using System;

[HarmonyPatch]
public class DisableTutorialButton : MonoBehaviour
{
    static MethodBase TargetMethod() => STN.ModSDK.HarmonyTargets.MethodCached("CursorManager:Start", Type.EmptyTypes);
    static void Postfix(object __instance)
    {
        (__instance as MonoBehaviour).transform.GetChild(10).GetChild(3).Find("Tutorial").gameObject.SetActive(false);
    }
}
