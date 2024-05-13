using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jugador : MonoBehaviour
{
    public float speed = 2;
    public KeyCode leftKey, rightKey, upKey, downKey, botonIz, botonDer;
    //public GameObject R;
    private SpriteRenderer _rend;
    private Rigidbody2D _rb;
    private Vector2 _dir;
    void Start()
    {
        _rend = GetComponent<SpriteRenderer>();
        _rb = GetComponent<Rigidbody2D>();
        _rend.sprite = GameManager.instance.character.GetSprite();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    private void FixedUpdate()              //para las fisicas
    {
        _rb.velocity = new Vector3(speed, speed) * _dir;
    }

    void Movement()
    {
        _dir = new Vector2(0, 0);

        if (Input.GetKey(leftKey))
        {
            _dir = new Vector2(-1, _dir.y);
        }
        else if (Input.GetKey(rightKey))
        {
            _dir = new Vector2(1, _dir.y);
        }
        else if (Input.GetKey(upKey))
        {
            _dir = new Vector2(_dir.x, 1);
        }
        else if (Input.GetKey(downKey))
        {
            _dir = new Vector2(_dir.x, -1);
        }
        else if (Input.GetKey(botonIz))
        {
            //GameManager.instance.GetHeal();
        }
        else if (Input.GetKey(botonDer))
        {
            //GameManager.instance.GetDamage();
        }
    }
}
