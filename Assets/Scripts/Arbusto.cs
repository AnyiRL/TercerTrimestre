using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arbusto : MonoBehaviour
{
    public GameObject enemy;
    private float  index = 0;
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        float valor = Random.Range(-1, 2);
        if (valor > 0 && index==0)
        {
            Instantiate(enemy, transform.position, Quaternion.identity);
            index++;
        }else
        {
            Debug.Log("No hay enemigo");
        }
    }
}
