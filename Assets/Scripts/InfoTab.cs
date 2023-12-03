using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InfoTab : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _Info;

    public void SetText(string _text)
    {
        _Info.text = _text;
    }
}
