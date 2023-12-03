using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public static class ConfigLoader
{
    public static ProjectConfiguration Config { get; private set; }
    public static GameObject Enviroment { get; private set; }
    public static int LoadingSceneIndex { get; set; }

    public static void SetConfig(ProjectConfiguration _config)
    {
        Config = _config;
    }

    public static void SetEnviroment(GameObject _enviroment)
    {
        Enviroment = _enviroment;
    }
    
}
