using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cowboy : character
{
    

    public Cowboy(string name, float damage) : base(name, damage)           //llamar a los componentes de character
    {
       //construimos hijo
    }

    public float Attack()
    {

        return Random.Range(damage, damage * 2);
    }
}
