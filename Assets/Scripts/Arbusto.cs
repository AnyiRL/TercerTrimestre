using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arbusto : MonoBehaviour
{
    public GameObject enemy;
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)           // Collider quién se ha chocado
    {
        Instantiate(enemy, transform.position, Quaternion.identity);
    }
}
