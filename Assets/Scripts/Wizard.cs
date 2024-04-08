using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard :character
{
  
    private bool hasHat;
    


    public Wizard(string name,float damage, bool hasHat) : base (name,damage)  //construimos padre
    {
    
        this.hasHat = hasHat;
  
    }

    public bool HasHat()         //getter
    {
        return hasHat;
    }

   

    public float Attack()
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

}
