using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard :character
{
  
    private bool hasHat;
    private float currentTime;
    public float maxTime = 4;

    public Wizard(string name,float damage, bool hasHat) : base ( name,damage, Resources.Load<Sprite>("Sprite"))  //construimos padre
    {
    
        this.hasHat = hasHat;
        SetJumpForce(2.5f);
        color = Color.yellow;
    }

    public bool HasHat()         //getter
    {
        return hasHat;
    }

   

    public override float Attack()
    {
        //if (hasHat)
        //{
        //    return damage * 2;
        //}else
        //{
        //    return damage;
        //}
        
        return hasHat ? damage * 2 : damage;              //es lo mismo que lo de arriba pero abreviado    operacion ternaria     ? = pregunta si es true o false
    }

    public override void Skill(Rigidbody2D rb)
    {
        rb.gravityScale = 0f;
        rb.velocity = Vector3.zero;
    }
    public override void Update(Rigidbody2D rb)
    {
       if(rb.gravityScale == 0)
        {
            currentTime += Time.deltaTime;
        }

        
        if (currentTime <= maxTime)

        {
            rb.gravityScale = 1;
        }
    }

}
