using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void UISwitch(GameObject _object)
    {
        if (_object.activeSelf)
        {
            _object.SetActive(false);
        }
        else
        {
            _object.SetActive(true);
        }
    }
}
