using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public abstract class Character       //no deja contruir un personaje al ser abstracto dentro solo pueden estar conceptos abstractos
{
    private string name;               //publico accesible a todo
    protected float damage;           //privado solo accesible dentro de la clase, clase hijos no o fuera de la clase
                                      //protected solo accesible detro de la clase, clase hijos pero no fuera 
    public float health;
    private Sprite _sprite;
    protected float jumpforce;
    //public Color color;

    public Character(string name, Sprite sprite, float damage)
    {
        this.name = name;
        this.damage = damage;
        _sprite = sprite; 
    }

    public string GetName()
    {
        return name;
    }
    public Sprite GetSprite() 
    { 
        return _sprite; 
    }

    public float GetDamage()         //getter
    {
        return damage;
    }

  
    public abstract float Attack();
    

    public virtual float Heal()                        //permite a los hijos sobreescribir a los padres, si no hay se usa el del padre
    {
        
        //GameManager.instance.GetHeal();
        health = Mathf.Clamp(health, 0, 100);          // clamp el valor entre 0,100 si se pasa escribe 100 y si es menor que 0 devuleve 0 
        return health;
    }

    //public abstract void Skill(Rigidbody2D rb);

    //{
    //    Debug.Log("character Ataca");
    //    return damage;
    //}

    //public float GetJumpForce()
    //{
    //    return jumpforce;
    //}
    //public void SetJumpForce (float jF)
    //{
    //    if(jF >0) 
    //    {
    //        this.jumpforce = jF;
    //    }

    //}

    //public Color GetColor()
    //{
    //    return Color.white;
    //}
}


