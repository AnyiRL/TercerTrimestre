using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DropDown : MonoBehaviour
{
    public TextMeshProUGUI output;

    public void ChooseCharacter(string sceneName)
    {
        GameManager.instance.SelectCharacter();
    }
}
