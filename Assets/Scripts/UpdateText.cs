using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
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

    }

    public void VidaP(float vida)
    {
        textComponent.text = "Vida personaje" + GameManager.instance.character.Heal();
    }
    public void VidaE(float vidaE)
    {
        textComponent.text = "Vida enemigo " + GameManager.instance.character.Heal();
    }
    public void DanioP(float danioP)
    {
        textComponent.text = "Daño personaje" + GameManager.instance.character.Attack();
    }
    public void DanioE(float danioE)
    {
        textComponent.text = "Daño " + GameManager.instance.character.Attack();
    }

}


