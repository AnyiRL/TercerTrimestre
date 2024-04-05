using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PooTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //float x1, y1, z1;

        RPMI.Vector3 vector3 = new RPMI.Vector3();
        print(vector3.GetName() + " " + vector3.x);
        RPMI.Vector3 vector3_1 = new RPMI.Vector3("Vector3_1", 50, 10, -69);
        print(vector3.GetName() + " " + vector3_1.x);
       
        RPMI.Vector3 vector3_2 = new RPMI.Vector3("Vector3_2", 0, 10, 9);
        print(" El Vector " + vector3.GetName() + " mide " + vector3_2.Modulo());  //modulo = raiz de la suma al cuadrado
        vector3_2.Add(5, 10, -45);  //5,20,34
        vector3_2.Add(new RPMI.Vector3 ("a",1, 1, 1)); //6,21,-35
        vector3_2.Mul(10); //60,210,-350
    }

   
}
