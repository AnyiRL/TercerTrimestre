using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cowboy : character
{
    

    public Cowboy(string name, float damage) : base(name, damage, Resources.Load<Sprite>("Sprite"))           //llamar a los componentes de character
    {
        //construimos hijo

        SetJumpForce(5);
        color = Color.yellow;
    }

    public override float Attack()
    {
        Debug.Log("Cowboy ataca");
        return Random.Range(damage, damage * 2);
    }

    public override float Heal()
    {
        Debug.Log("El cowboy se cura");
        health += 10;
        base.Heal();    //invoca a la cura del metodo del padre
        return 10;
    }

    public override void Skill(Rigidbody2D rb)
    {
        throw new System.NotImplementedException();
    }
}
