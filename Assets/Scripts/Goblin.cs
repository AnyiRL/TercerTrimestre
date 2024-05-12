using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : Character
{
    public Goblin() : base("Goblin", Resources.Load<Sprite>("Sprite"), 10)  //construimos padre
    {

    }

    public override float Attack()
    {
        return health < 20 ? damage * 3 : damage;
    }

    public override float Heal()
    {
        float valor = health / 2;
        health += valor;
        return valor;
    }


}
