using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    
    public int rows = 2;
    public int cols = 2;
    public GameObject arbusto;
    void Start()
    {
        Arbusto();
    }
    
    
    private void Arbusto()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                               
                Vector3 position = new Vector3(cols * j, rows * i, 0f );
                Instantiate(arbusto, position, Quaternion.identity);
            }
        }
    }


}
