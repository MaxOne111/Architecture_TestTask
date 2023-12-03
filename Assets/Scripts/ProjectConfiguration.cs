using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.SceneManagement;

[CreateAssetMenu(menuName = "Project Configuration", fileName = "ProjectConfiguration")]
public class ProjectConfiguration : ScriptableObject
{
    [SerializeField] private string _Name;
    [SerializeField] private GameLogic _Logic;
    [SerializeField] private AssetReference _Enviroment;
    
    public string Name{get=>_Name;}
    public AssetReference Enviroment{get=>_Enviroment;}
    public GameLogic Logic{get=>_Logic;}
}
