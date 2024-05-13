using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DropDown : MonoBehaviour
{
    public TextMeshProUGUI output;

    public void LoadScene(string sceneName)
    {
        GameManager.instance.LoadScene(sceneName);
    }
}
