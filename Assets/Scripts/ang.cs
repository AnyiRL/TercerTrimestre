using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class ang : Personaje
{
    private float currentTime;
    public float maxTime = 4;
    private Vector2 dir;
    private Animator _animator;

   
    public ang(string name, float damage) : base(name, damage, Resources.Load<Sprite>("Sprite"))  //construimos padre
    {
        SetJumpForce(2.5f);
  
    }
   
    public override void Skill(Rigidbody2D rb)
    {
        
        dir = Vector2.zero;
        rb.gravityScale = 0;
        if (Input.GetKey(upKey))
        {
            _animator.Play("subir");
            dir = new Vector2(0, 1);


        }
        else if (Input.GetKey(downKey))
        {
            _animator.Play("bajar");
            dir = new Vector2(0, -1);

        }
        

    }
    public override void Update(Rigidbody2D rb)
    {
        if (rb.gravityScale == 0)
        {
            currentTime += Time.deltaTime;
        }


        if (currentTime <= maxTime)

        {
            rb.gravityScale = 1;
            
        }
    }

    

}
