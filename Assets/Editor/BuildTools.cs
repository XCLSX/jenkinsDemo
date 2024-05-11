using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BuildTools : MonoBehaviour
{
    // Start is called before the first frame update
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
        BuildPlayerOptions opt = new BuildPlayerOptions();
        opt.scenes = new string[] {"Assets/Scenes/SampleScene.unity"};
        opt.locationPathName = Application.dataPath + "/../Bin/test.apk";
        opt.target = BuildTarget.Android;

        BuildPipeline.BuildPlayer(opt);
        Debug.Log("Build App Done!");
    }
}