using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TextCore.Text;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public enum GameManagerVariables { DAMAGE, HEAL, HEALTH,};  //enum declarar estructura sirve para facilitar la lectura a otros programadores

    
    private float damage;
    private float health = 100;
    private float heal;
    private float  initialHealth;
    public Character character;
    

    private void Awake()
    {

        //Singleton         //singleton accesible para cualquiera, solo existe una instancia  
        if (!instance)     // si instance no tiene informacion
        {
            instance = this;    // instance se asigna a este objet.                                 el gameManager querra crearse, si no hay otro antes este sera el principal
            DontDestroyOnLoad(gameObject);        //no se destruye con la carga de escenas 
        }
        else
        {
            Destroy(gameObject);    //se destruye el  gameObject para que no  haya dos o mas gm en el juego
        }

        //character = new Wizard("anyi", 1);
    }

    void Start()
    {        
        initialHealth = health;
        
    }

    public void Reset()
    {        
        health = initialHealth;        
    }


    //public float GetHealth()
    //{
    //    return health;
    //}

    //public float GetHeal()
    //{
    //    return heal;
    //}

    //public float GetDamage()
    //{
    //    return damage;
    //}

    
    public void SelectCharacter()
    {
        TMP_Dropdown dropdown = FindObjectOfType<TMP_Dropdown>();
        if (dropdown.value == 0)
        {
            character = new Cowboy("Cowboy");
        }
        else if (dropdown.value == 1)
        {
            character = new Wizard("Wizard", 2);
        }
    }


    


    //public void AddHealth(float heal)
    //{
    //    health += heal;
    //}
    //public void RHealth(float saludARestar)
    //{
    //    health -= saludARestar;
    //    if (health <= 0)
    //    {
    //       // FindAnyObjectByType<Mario>().ResetGame();
    //    }
    //}
    



    
}
