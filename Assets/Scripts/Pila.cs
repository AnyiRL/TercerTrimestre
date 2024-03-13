using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pila : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        //Stack<int> pila = new Stack<int>();
        //pila.Push(4);
        //pila.Push(-5);   
        //pila.Push(-10);
        //pila.Push(88);
        //pila.Push(2);

        //Stack<int> pila2 = new Stack<int>();
        //while (pila.Count<0)
        //{
        //    int popNumber = pila.Pop();
        //    if (popNumber > pila.Pop() && popNumber > pila2.Pop())
        //    {

        //        pila2.Push(popNumber);
        //        pila.Push(pila.Pop());

        //    }

        //    else 
        //    {
        //        pila2.Push(pila.Pop());
        //        pila.Push(popNumber);
        //    }

        //}
        //while (pila2.Count < 0)
        //{
        //    int popNumber = pila2.Pop();
        //    pila.Push(popNumber);

        //}
        //Debug.Log(pila);

        Stack<int> originalStack = new Stack<int>();
        originalStack.Push(4);
        originalStack.Push(-5);
        originalStack.Push(-10);
        originalStack.Push(88);
        originalStack.Push(2);

        Stack<int> stack1 = new Stack<int>();
        Stack<int> stack2 = new Stack<int>();

        // vaciamos la pila original y le damos todos los valores a la pila 1 para empezar a trabajar
        while (originalStack.Count > 0)
        {
            stack1.Push(originalStack.Pop());
        }

        while (stack1.Count > 0)
        {
            int aux = stack1.Pop();
            while (stack1.Count > 0)
            {
                if (stack1.Peek() < aux)
                {
                    stack2.Push(aux);
                    aux = stack1.Pop();
                }
                else
                {
                    stack2.Push(stack1.Pop());
                }
            }

            // el menor valor es aux
            originalStack.Push(aux);

            // swap de pilas
            Stack<int> auxStack = stack1;
            stack1 = stack2;
            stack2 = auxStack;
        }

        while (originalStack.Count > 0)
        {
            Debug.Log(originalStack.Pop());
        }
    }

}

    

