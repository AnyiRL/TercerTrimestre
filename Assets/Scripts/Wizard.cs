using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard :Character
{
  
    
    //private float currentTime;
    private float damageMultiplier ;
    //public float maxTime = 4;

    public Wizard(float damageMultiplier, string name) : base ( name, Resources.Load<Sprite>("Sprites/wizard"),20)  //construimos padre
    {
        this.damageMultiplier = damageMultiplier;
 
        //SetJumpForce(2.5f);
        //color = Color.yellow;
    }

    //throw new System.NotImplementedException()   
   

    public override float Attack()
    {
        Debug.Log("Mago ataca");
        return damage * damageMultiplier;
        
        //if (hasHat)
        //{
        //    return damage * 2;
        //}else
        //{
        //    return damage;
        //}
        
        //return hasHat ? damage * 2 : damage;              //es lo mismo que lo de arriba pero abreviado    operacion ternaria     ? = pregunta si es true o false
    }

    public override float Heal ()          //sobreescribe el metodo padre
    {
        Debug.Log("El mago se cura");
        float valor = Random.Range(damage, damage * damageMultiplier);
        health += valor;
        base.Heal(); //invoca al metodo padre
        return valor; // que devuelve, el valor de vida o lo que restaura

    }

    //public override void Skill(Rigidbody2D rb)
    //{
    //    rb.gravityScale = 0f;
    //    rb.velocity = Vector3.zero;
    //}
    //public override void Update(Rigidbody2D rb)
    //{
    //   if(rb.gravityScale == 0)
    //    {
    //        currentTime += Time.deltaTime;
    //    }

        
    //    if (currentTime <= maxTime)

    //    {
    //        rb.gravityScale = 1;
    //    }
    //}

}
