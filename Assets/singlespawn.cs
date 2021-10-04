using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class singlespawn : MonoBehaviour
{

    public bool Death;
    public float Timer;
    public float Cooldown;
    public GameObject angyss;
    public string EnemyName;
    GameObject LastEnemy;

    // Start is called before the first frame update
    void Start()
    {

       Death = false;
        this.gameObject.name = EnemyName + "spawn point";
    }

   
   
    // Update is called once per frame
    void Update()
    {
        if (Death == true) //if value is same on both sides./ if statement is true.
        {
            Timer += Time.deltaTime;
        }
       
        if(Timer >= Cooldown)
        {
            angyss.transform.position = transform.position;

            Instantiate(angyss);
            LastEnemy = GameObject.Find(angyss.name + "(clone)");
            
            LastEnemy.name = EnemyName;

            Death = false;

            Timer = 0;
        }
        
    }
}
