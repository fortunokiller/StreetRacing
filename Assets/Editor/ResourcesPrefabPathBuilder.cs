#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;
using UnityEngine.SceneManagement;

public class ResourcesPrefabPathBuilder : IProcessSceneWithReport
{
    public int callbackOrder { get { return 0; } }

    public void OnProcessScene(Scene scene, BuildReport report)
    {
        MasterManager.PopulateNetworkPrefabs();
    }
}
#endif