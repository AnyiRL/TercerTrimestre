using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    
    public int rows = 2;
    public int cols = 2;
    public float xDist = 0.5f;
    public float yDist = 0.5f;
    public List<GameObject> arbusto,arbusto1;
    void Start()
    {
        //Instantiate(arbusto, new Vector2(Random.Range(-10.96f, 11.27f), Random.Range(-4.11f,3.98f)), Quaternion.identity);
        Arbusto();
    }
    
    
    private void Arbusto()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int a = 0; a < cols; a++)
            {
                xDist = Random.Range(-2, 2);
                xDist = Random.Range(-2, 2);               
                int randomIndex = Random.Range(0, arbusto.Count);
                Vector3 position = new Vector3(cols * xDist, 0f, rows * yDist);
                Instantiate(arbusto[randomIndex], position, Quaternion.identity);
                Instantiate(arbusto1[randomIndex], position, Quaternion.identity);
            }
        }
    }


}
