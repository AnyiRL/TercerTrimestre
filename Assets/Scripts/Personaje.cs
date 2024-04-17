using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    private float currentTime = 0;
    private SpriteRenderer _rend;
    private Rigidbody2D rb;
    private Vector2 dir;
    private bool _intentionToJump;
    private Animator _animator;
    private Vector3 originalPosition;
    private bool habilityOn;
    private float originalSpeed;


    public string name;               //publico accesible a todo
    protected float damage;           //privado solo accesible dentro de la clase, clase hijos no o fuera de la clase
                                      //protected solo accesible detro de la clase, clase hijos pero no fuera 
    public float health;

    public Personaje(string name, float damage)
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

    

    // Update is called once per frame
    void Update()
    {

        dir = Vector2.zero;

        MoveX();

        if (Input.GetKey(leftKey))
        {
            _rend.flipX = true;
            dir = new Vector2(-1, 0);
        }
        else if (Input.GetKey(rightKey))
        {
            _rend.flipX = false;
            dir = new Vector2(1, 0);
        }



        _intentionToJump = false;
        if (Input.GetKey(jumpKey))
        {
            _intentionToJump = true;
        }
        if (dir != Vector2.zero)                     //andando                           //#region #endregion para ordenar el codigo
        {
            _animator.SetBool("isWalking", true);
            //AudioManager.instance.PlayAudio(walkClip, "walkSound");
            //_animator.Play("walk");
        }
        else                                        //parados
        {
            _animator.SetBool("isWalking", false);
            //_animator.Play("walk");
        }
        currentTime += Time.deltaTime;                            //Time.deltaTime - Tiempo en segundos que tarda en completarse el último frame //currentTime total
        if (currentTime >= 2.5f)
        {
            _animator.SetBool("idle", true);
            currentTime = 0;
            //AudioManager.instance.PlayAudio(idleClip, "idleSound");

        }

        if (habilityOn)
        {
            Escalera();
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

            _animator.Play("bajar");
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
    public void Escalera()

    {
        dir = Vector2.zero;
        if (Input.GetKey(upKey))
        {
            _animator.Play("subir");
            dir = new Vector2(0, 1);
            //AudioManager.instance.PlayAudio(escaleraUpClip, "upSound");

        }
        else if (Input.GetKey(downKey))
        {
            _animator.Play("bajar");
            dir = new Vector2(0, -1);
            //AudioManager.instance.PlayAudio(escaleraDclip, "DSound");
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
            rb.gravityScale = 0;
            speed = originalSpeed / 10;
        }
        else
        {
            rb.gravityScale = 1;
            speed = originalSpeed;
        }
    }

    public bool GetHability()
    {
        return habilityOn;
    }
    
    

}
