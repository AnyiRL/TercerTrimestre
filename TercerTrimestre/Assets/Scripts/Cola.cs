using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cola : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Queue<int> cola = new Queue<int>();
        cola.Enqueue(50);
        cola.Enqueue(80);
        cola.Enqueue(1);
        cola.Enqueue(9);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
