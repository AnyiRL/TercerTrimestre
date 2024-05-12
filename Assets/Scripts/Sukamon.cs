using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sukamon : Character
{

    public Sukamon() : base("Sukamon", Resources.Load<Sprite>("Sprite"), 1)           //llamar a los componentes de character
    {
        
    }

    public override float Attack()
    {
        Debug.Log("Sukamon ataca");
        return health < 5 ? 100 : 1;  
    }

    public override float Heal()
    {
        float valor = damage / 3;
        health += valor;
        base.Heal();
        return valor;
    }
}