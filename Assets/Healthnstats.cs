using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//calls UI library to fiddle with Healthbar
using System;

public class Healthnstats : MonoBehaviour
{
    private int maxHealth;  // all four is public so we can call from them to f.example healthbar. displays Maxhealth
   [SerializeField]
    private int currentHealth; //displaysCurrent health
    private int baseHealth; //displays Base Health

    
    

    private int level;   //displays Level
    [SerializeField]
    public int pdamage;
    public angystats damagefromangy; //drag and drop angy here so we can use refrences from his dmg stats. <-- important
    public GameObject Angyobj;

    
  // private angystats ScriptAccess; //litterally the only way to gain access to angystats damage function.
    public int basedamage; //this is our base dmg
    private int strenght;  // this ius our base strenght stat
    
    // Start is called before the first frame update
    void Awake()
    {

        

        baseHealth = 10;
        level = 1; //add xp and more levels later
        strenght = 2; // add ( 2 + (1*level)) as integer later.
        basedamage = 10;


        maxHealth = baseHealth + (level * 10); //calls this fuction firsts to specify what max heal is, before taking current health as maxhealth from start.
        //healthBar.SetMaxHealth(maxHealth); // sets the healthbar equal to maxhealth, whitch is specified in line above
        currentHealth = maxHealth; //calls current health as the specified maxhealth.
        pdamage = (strenght * level) + basedamage;

    }
    
    void OnCollisionEnter2D(Collision2D col)  //on collison 2d fuction
    {
        if (Angyobj != null) // if ''angyobj->testmob'' is not equal to null then
        {
            
            Angyobj.gameObject.GetComponent<angystats>().mobTakeDamage(pdamage);

            Debug.Log("emo-attack");

        }
    }
}
    /*

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
    }

    */
    // Update is called once per frame
   // void Update()
    //{
        //if (Angyobj != null)
        //{
      //      ScriptAccess = damagefromangy.GetComponent<angystats>(); // get acces from--''damagefromangy'' here we drag and drop angy. get access to angystats script.

    //        angydmg = ScriptAccess.damage; //make own refrence as angydmg, from damage value in angystats.

  //          healthBar.SetHealth(currentHealth);


//        }

   // }

