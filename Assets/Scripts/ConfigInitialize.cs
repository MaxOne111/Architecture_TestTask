using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;

public class ConfigInitialize : MonoBehaviour
{
    private ProjectConfiguration _Config;

    private AssetReference _Asset_Reference;

    private void Start()
    {
        ConfigInit();

        LoadEnviroment();
        
        LoadLogic();
    }

    private void ConfigInit()
    {
        if (ConfigLoader.Config)
        {
            _Config = ConfigLoader.Config;
        }
    }

    private void LoadEnviroment()
    {
        Instantiate(ConfigLoader.Enviroment);
    }

    private void LoadLogic()
    {
        Instantiate(_Config.Logic);
    }
}
