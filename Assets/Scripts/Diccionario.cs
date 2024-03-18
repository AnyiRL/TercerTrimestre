using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diccionario : MonoBehaviour
{
    
    public string simboloToSearch;
    void Start()
    {
        Dictionary<string, char> simbolo = new Dictionary<string, char>();

        simbolo.Add("euro", '€');
        simbolo.Add("dollar", '$');
        simbolo.Add("yen", '¥');

        //Console.WriteLine("Ingrese moneda:");    //para consola
        //string moneda = Console.ReadLine();


        //if (simbolo.ContainsKey("moneda"))
        //{
        //    Console.WriteLine(simbolo["moneda"]);
        //}
        //else
        //{
        //    Console.Write("Error");
        //}

        if (simbolo.ContainsKey(simboloToSearch.ToLower()))               //Pasar todo a minuscula
        {
            print(simbolo[simboloToSearch.ToLower()]);
        }
        else
        {
            print("No contiene esta key");
        }

        //Dictionary<string, string[]> rae = new Dictionary<string, string[]>();
        

    }
}
