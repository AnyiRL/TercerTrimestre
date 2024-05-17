using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class StartCombat : MonoBehaviour
{
    //private void Awake()
    //{
    //    CombatController controller= 
    //}
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Jugador pm = collision.GetComponent<Jugador>();
        if (pm)
        {
            pm.enabled = false;
            Enemy enemyType = (Enemy)Random.Range((int)Enemy.GOBLIN, (int)Enemy.SUKAMON);
            Character enemy = null;

            
        }
        CombatController cc = pm.AddComponent<CombatController>();
        //cc.enemy = enemy;
    }
}
