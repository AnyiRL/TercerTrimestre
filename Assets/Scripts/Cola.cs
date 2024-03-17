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
            cola1.Enqueue(cola1.Dequeue());
        }
        Cola1();

        void Cola1()
        {
            while (cola1.Count > 0)
            {
                int aux = cola1.Dequeue();
                while (cola1.Count > 0)
                {
                    if (cola1.Peek() < aux)    //Peek() indica el numero que va a salir SIN SACARLO
                    {
                        cola2.Enqueue(aux);
                        aux = cola1.Dequeue();
                    }
                    else
                    {
                        cola2.Enqueue(cola1.Dequeue());
                    }
                }
                cola.Enqueue(aux);  //num mas pequenio
                Cola2();
            }
        }    

        void Cola2()
        {
            while (cola2.Count > 0)
            {
                int aux = cola2.Dequeue();
                while (cola2.Count > 0)
                {
                    if (cola2.Peek() < aux)    //Peek() indica el numero que va a salir SIN SACARLO
                    {
                        cola1.Enqueue(aux);
                        aux = cola2.Dequeue();
                    }
                    else
                    {
                        cola1.Enqueue(cola2.Dequeue());
                    }
                }
                cola.Enqueue(aux);  //num mas pequenio
                Cola1();
            }
        }      

        while (cola.Count > 0)
        {
            Debug.Log(cola.Dequeue());
        }

        Dictionary<string, char> simbolo = new Dictionary<string, char>();

        simbolo.add("Euro", €);
        simbolo.add("Dollar", $);
        simbolo.add("Yen", ¥);

        Console.WriteLine("Ingrese moneda:");
        string moneda = Console.ReadLine();


        if (simbolo.ContainsKey("moneda"))
        {
            Console.WriteLine(simbolo["moneda"]);
        }      
        else
        {
            Console.Write("Error");
        }

        

    }


}





