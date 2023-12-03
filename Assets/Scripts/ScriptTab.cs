using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScriptTab : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _Script_Name;
    
    [SerializeField] private ProjectConfiguration _Config;
    
    [SerializeField] private int _Loading_Scene_Index;

    private void Start()
    {
        _Script_Name.text = _Config.Name;
    }

    public void LoadScript()
    {
        ConfigLoader.SetConfig(_Config);
        ConfigLoader.LoadingSceneIndex = _Loading_Scene_Index;
        
        SceneManager.LoadScene("LoadingScreen");
    }
}
