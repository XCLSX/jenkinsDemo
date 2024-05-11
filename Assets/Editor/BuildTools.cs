using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BuildTools : MonoBehaviour
{
    // Start is called before the first frame update
    private static string AndroidKeyPass = "123456";
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    [MenuItem("Tools/Build APK")]
    public static void BuildApk()
    {
        PlayerSettings.Android.keyaliasPass = AndroidKeyPass;
        PlayerSettings.Android.keystorePass = AndroidKeyPass;
        BuildPlayerOptions opt = new BuildPlayerOptions
        {
            scenes = new string[] {"Assets/Scenes/SampleScene.unity"},
            locationPathName = Application.dataPath + "/../Bin/test.apk",
            target = BuildTarget.Android
        };

        BuildPipeline.BuildPlayer(opt);
        Debug.Log("Build App Done!");
    }
}