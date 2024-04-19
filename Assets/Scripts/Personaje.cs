using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.U2D;

public abstract class Personaje 
{
    public float speed;
    public KeyCode leftKey, rightKey, jumpKey;
    public float LayerCast;
    public float jumpForce;
    public float rayDistance;
    public KeyCode upKey, downKey;
    public LayerMask groundMask;   //capa de colisiones
    public AudioClip jumpClip, walkClip, idleClip, escaleraUpClip, escaleraDclip;

    
    private SpriteRenderer _rend;
    private Rigidbody2D rb;
    private Vector2 dir;
    
    private Animator _animator;
   
    private bool habilityOn;
    private float originalSpeed;


    public string name;               //publico accesible a todo
    protected float damage;           //privado solo accesible dentro de la clase, clase hijos no o fuera de la clase
                                      //protected solo accesible detro de la clase, clase hijos pero no fuera 
    public float health;
    protected Sprite _sprite;
    protected float jumpforce;
    public Color color;

    public Personaje(string name, float damage, Sprite sprite)
    {
        this.name = name;
        this.damage = damage;
        _sprite = sprite;
    }

    public Sprite GetSprite()
    {
        return _sprite;
    }
    public float GetJumpForce()
    {
        return jumpforce;
    }
    public void SetJumpForce(float jF)
    {
        if (jF > 0)
        {
            this.jumpforce = jF;
        }

    }
    public abstract void Skill(Rigidbody2D rb);
    public virtual void Update(Rigidbody2D rb)
    {

    }


    // Update is called once per frame
    void Update()
    {

        dir = Vector2.zero;

        

        if (habilityOn)
        {
            Volar();
        }else
        {
            MoveX();
        }


    }
    public void MoveX()
    {
        if (Input.GetKey(leftKey))
        {
            _rend.flipX = true;
            dir = new Vector2(-1, 0);
        }
        else if (Input.GetKey(rightKey))
        {
            _rend.flipX = false;
            dir = new Vector2(1, 0);
        }else if (Input.GetKey(downKey))
        {

            _animator.Play("agachar");
        }
    }

    

    private void FixedUpdate()
    {
        
        if (dir != Vector2.zero)
        {
            float currentYVel = rb.velocity.y;                            //para que la velocidad de la caida sea constante
            Vector2 nVel = dir * speed;
            nVel.y = currentYVel + nVel.y;
            rb.velocity = nVel;
        }

                             
    }
    public void Volar()

    {
        dir = Vector2.zero;
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
        else if (Input.GetKey(rightKey) || Input.GetKey(leftKey))
        {
            MoveX();
            rb.gravityScale = 0;
            speed = originalSpeed / 10;
        }


    }


   
    

    


    public void SetHability(bool value)
    {
        habilityOn = value;
        if (value)
        {
            Volar();
        }
        else
        {
            MoveX();
        }
    }

    public bool GetHability()
    {
        return habilityOn;
    }
    
    

}
