using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatController : MonoBehaviour
{
    public Character character;
    public Character enemy;
     
    private float healthE;
    private float healthP;
    private float danio;
    private float vida;


    public KeyCode botonIz, botonDer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //public float AttackP()
    //{
    //    if (Input.GetKey(botonIz))
    //    {
    //        danio = GameManager.instance.character.Attack();
    //        healthE -= danio; 
    //    }
    //    return healthE;
    //}
    //public float HealP()
    //{
    //    if (Input.GetKey(botonDer))
    //    {
    //        vida = GameManager.instance.character.Heal();
    //        healthP += danio;
    //    }
    //    return healthP;
    //}

}
