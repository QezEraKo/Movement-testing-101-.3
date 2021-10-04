using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  //calls UI library to fiddle with Healthbar

public class angystats : MonoBehaviour
{
    private int maxHealth;  // all four is public so we can call from them to f.example healthbar. displays Maxhealth
    [SerializeField]
    private int currentHealth; //displaysCurrent health
    private int baseHealth; //displays Base Health
    public Healthnstats damagetoangy;
    //public HealthBar healthBar; //Drag and drop angy health here, and will call the script this object has, that is called '' HealthBar'' This allows us to use it's fuctions.
    GameObject statobject;

    private UnityEngine.Object enemyRef;
    //private Healthnstats ScriptAccess;
    [SerializeField]
    private int damage; //displays Damage
    private int playerdmg;  //refrence to players damage
    private int basedamage; // angys base damage
    private int strenght;  // angrys strenght
    private int level;     //displays Level

    //public HealthBar healthBar; //Drag and drop angy health here, and will call the script this object has, that is called '' HealthBar'' This allows us to use it's fuctions.
    //statobject.GetComponent<statsAngy>();
    // Start is called before the first frame update
    void Start()
    {
        baseHealth = 5;
        level = 1;
        strenght = 2;
        basedamage = 10;
        enemyRef = Resources.Load("test mob");
        maxHealth = baseHealth + (level * 10); //calls this fuction firsts to specify what max heal is, before taking current health as maxhealth from start.
        //healthBar.SetMaxHealth(maxHealth); // sets the healthbar equal to maxhealth, whitch is specified in line above
        currentHealth = maxHealth; //calls current health as the specified maxhealth.
        damage = (strenght * level) + basedamage; // sets damage as strenght modifier times lvl, pluss base damage.
    }

    //in next line: make a fuction called mobTakeDamage for refrence. And the int,string,float etc type. Last make a refrence for the damage that is on the oposing object ( player)
    public void mobTakeDamage(int dmgAmount) //use int if made int or float for float (refering to current health and the stat that willl be transfered troung dmgAmount
    {
        currentHealth -= dmgAmount;  // current health minus ''dmgAmount'' dmg amount is the '' int pdamage'' from the collision function
    }





    /*
    //   void OnCollisionEnter2D(Collision2D col)
    //   {
    //    if (col.gameObject.tag == ("Player"))
    //    {
    //       DealDamage(playerdmg); //do a "takeDamage" and value "playerdmg->damage in script Healthnstats"

    //   if (currentHealth <= (0)) //if health is lower of equal to 0
    //   {
    //      killSelf(); // execute this function

    //    }


    //  }
    // }

    void DealDamage(int damages)
    {
        currentHealth -= damages;
    }


    // Update is called once per frame
    void Update()
    {
        ScriptAccess = damagetoangy.GetComponent<Healthnstats>();

        playerdmg = ScriptAccess.damage;

        healthBar.SetHealth(currentHealth);


    }

    private void killSelf()  //this function will do
    {

        gameObject.SetActive(false); //sett the gameobject that the script is attached to as not active

        Invoke("Respawn", 5);  //Invoke <- will execute function called "Respawn" in 5 secounds. 

    }

    void Respawn() //Function called Respawn
    {
        GameObject enemyClone = (GameObject)Instantiate(enemyRef); //load cloned enemy to the scene. gameobject "enemyClone" is set to ( spawn clone of self )
        enemyClone.transform.position = transform.position; // map it to the current position of the current enemy. the position of "enemyClone" is the same as the object this script is set to.

        Destroy(gameObject); //Removes gameObject from scene
    }


    */
}





