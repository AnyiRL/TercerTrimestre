using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cowboy : Character
{
    

    public Cowboy(string name) : base(name, Resources.Load<Sprite>("Sprite"), 15)           //llamar a los componentes de character
    {
        //construimos hijo

        //SetJumpForce(5);
        //color = Color.yellow;
    }

    public override float Attack()
    {
        Debug.Log("Cowboy ataca");

        return damage * Random.Range(1, 1.5f*health); // h se refiere a vida 
    }

    public override float Heal()
    {
        Debug.Log("El cowboy se cura");
        health += 10;
        base.Heal();    //invoca a la cura del metodo del padre
        return 10;
    }

    //public override void Skill(Rigidbody2D rb)
    //{
    //    throw new System.NotImplementedException();
    //}
}
