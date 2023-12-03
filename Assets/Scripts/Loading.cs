using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Loading : MonoBehaviour
{
    [SerializeField] private Image _Loading_Image;
    
    private AssetReference _Asset_Reference;


    private void Start()
    {
        StartCoroutine(LoadEnviroment());
    }

    private IEnumerator LoadEnviroment()
    {
        ProjectConfiguration _config = ConfigLoader.Config;
        int _scene_Index = ConfigLoader.LoadingSceneIndex;
        
        _Asset_Reference = _config.Enviroment;
        
        AsyncOperationHandle<GameObject> _handle = _Asset_Reference.LoadAssetAsync<GameObject>();

        while (!_handle.IsDone)
        {
            _Loading_Image.fillAmount = 1f / _handle.PercentComplete;
            yield return null;
        }
        
        yield return _handle;

        if (_handle.Status == AsyncOperationStatus.Succeeded)
        {
            ConfigLoader.SetEnviroment(_handle.Result);
            Addressables.Release(_handle);
        }

        SceneManager.LoadScene(_scene_Index);
    }
}
