using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class character       //no deja contruir un personaje al ser abstracto dentro solo pueden estar conceptos abstractos
{
    public string name;               //publico accesible a todo
    protected float damage;           //privado solo accesible dentro de la clase, clase hijos no o fuera de la clase
                                      //protected solo accesible detro de la clase, clase hijos pero no fuera 
    public float health;

    public character(string name, float damage)
    {
        this.name = name;
        this.damage = damage;
    }


    public float GetDamage()         //getter
    {
        return damage;
    }

    public abstract float Attack();
    //{
    //    Debug.Log("character Ataca");
    //    return damage;
    //}
    
    public virtual float Heal()                        //permite a los hijos sobreescribir a los padres, si no hay se usa el del padre
    {
        Debug.Log("El character se cura");
        health = Mathf.Clamp(health, 0, 100);          // clamp el valor entre 0,100 si se pasa escribe 100 y si es menor que 0 devuleve 0 
        return health;
    }
}
    

