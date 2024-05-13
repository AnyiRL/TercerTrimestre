using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public enum GameManagerVariables { DAMAGE, TIME, HEAL};  //enum declarar estructura sirve para facilitar la lectura a otros programadores

    private float time;
    private float damage;
    private float health = 100;
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

        character = new Wizard("anyi", 1);
    }

    void Start()
    {        
        initialHealth = health;
    }

    public void Reset()
    {        
        health = initialHealth;        
    }


    void Update()
    {
        time += Time.deltaTime;
    }
    public float GetTime()
    {
        return time;
    }
    
    public float GetHeal()
    {
        return health;
    }

    public float GetDamage()
    {
        return damage;
    }


    //setter establecer, cambiar
    //public void SetTime(float value)   para cambiar tiempo
    //{
    //}


    public void AddHealth(float heal)
    {
        health += heal;
    }
    public void RHealth(float saludARestar)
    {
        health -= saludARestar;
        if (health <= 0)
        {
           // FindAnyObjectByType<Mario>().ResetGame();
        }
    }
    



    //callback funcion que se va a llamar en el on click de los botoones
    public void LoadScene(string sceneName)
    {
        Debug.Log("Start");
        SceneManager.LoadScene(sceneName);
        //AudioManager.instance.ClearAudios();                //audiomanager, limpia todos los sonidos que estan sonando
    }

    public void ExitGame()
    {
        Debug.Log("Exit!!");
        Application.Quit();
    }
}
