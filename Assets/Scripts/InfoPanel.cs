using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Localization.Settings;

public class InfoPanel : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _Locale;
    [SerializeField] private TextMeshProUGUI _Objects_Count;
    
    [SerializeField] private InfoTab _Info_Tab_Prefab;
    [SerializeField] private Transform _Content;

    private void Awake()
    {
        Info();
    }

    private void Start()
    {
        _Locale.text = LocalizationSettings.SelectedLocale.ToString();
        _Objects_Count.text =  $"Objects count: {ObjectsCount().ToString()}" ;
    }

    private void Info()
    {
        CreateInfoTab(ConfigLoader.Config.Name);
        CreateInfoTab(ConfigLoader.Enviroment.name);
        CreateInfoTab(ConfigLoader.Config.Logic.name);
    }
    
    private void CreateInfoTab(string _info)
    {
        GameObject _tab = Instantiate(_Info_Tab_Prefab.gameObject, _Content);
        _tab.GetComponent<InfoTab>().SetText(_info);
    }

    private int ObjectsCount()
    {
        return ConfigLoader.Enviroment.transform.childCount;
    }
}
