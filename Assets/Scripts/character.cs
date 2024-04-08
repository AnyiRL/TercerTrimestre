using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character
{
    public string name;               //publico accesible a todo
    protected float damage;           //privado solo accesible dentro de la clase, clase hijos no o fuera de la clase
                                      //protected solo accesible detro de la clase, clase hijos pero no fuera 
    

    public character(string name, float damage)
    {
        this.name = name;
        this.damage = damage;
    }


    public float GetDamage()         //getter
    {
        return damage;
    }

    
   
}
    

