using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Unity.Burst.Intrinsics.X86;

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

        Queue<int> cola1 = new Queue<int>();
        Queue<int> cola2 = new Queue<int>();

        while (cola.Count > 0)
        {
            cola1.Enqueue(cola.Dequeue());
        }

        while (cola1.Count > 0)
        {
            int aux = cola1.Dequeue();
            while (cola1.Count > 0)
            {
                if (cola1.Peek() < aux)
                {
                    cola2.Enqueue(aux);
                    aux = cola1.Dequeue();
                }
                else
                {
                    cola2.Enqueue(cola1.Dequeue());
                }
            }

            // el menor valor es aux
            cola.Enqueue(aux);

            // swap de pilas
            Queue<int> auxcola = cola1;
            cola1 = cola2;
            cola2 = auxcola;
        }

        while (cola.Count > 0)
        {
            Debug.Log(cola.Dequeue());
        }
    }        
}








