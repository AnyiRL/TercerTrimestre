using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UpdateText : MonoBehaviour
{
    public GameManager.GameManagerVariables variable;
    private TMP_Text textComponent;

    private void Start()
    {
        textComponent = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {

        switch (variable)
        {
            case GameManager.GameManagerVariables.TIME:
                textComponent.text = "Time: " + GameManager.instance.GetTime().ToString("F2");
                break;
            case GameManager.GameManagerVariables.DAMAGE:

                textComponent.text = "Daño de " +  GameManager.instance.GetDamage();
                break;
            case GameManager.GameManagerVariables.HEAL:
                textComponent.text = " " + GameManager.instance.GetHeal();
                break;
           

        }
    }
}


