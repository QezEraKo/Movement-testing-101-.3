using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    //private int plydmg;
    private Healthnstats ScriptAccess; //part 2 of using other script
    [SerializeField]
    private int plydmg; //player dmg ref for Script access route
    private int plydmg2; // reff via vanlig

    public Healthnstats playreff; //drag and drop player. This is Player Ref for script access.
    public GameObject ptestObj; //adding this to make bool
    public GameObject hitEffect;

    

    private void Start()
    {
        if (playreff != null)
        {
            ScriptAccess = playreff.GetComponent<Healthnstats>(); // Get access to Script "Healthnstats" from playreff->"Player"
            plydmg = ScriptAccess.pdamage; // make a refrence "plydmg" that is sett equal to pdamage in Healthnstats from the player

            plydmg2 = Healthnstats.pdamage; //reff via vanling 
           
        }





    }
     //last added was line. 8,9,18,20,21 and 48 (just the plydmg part in line 48)

    void Update()
    {
        if (ptestObj != null)
        {
            //ScriptAccess = playreff.GetComponent<Healthnstats>();

            //plydmg = ScriptAccess.pdamage;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject effect = Instantiate(hitEffect, transform.position, Quaternion.identity); // this instantiate a effect that gets instatiated at thetansformsposition and the transforms rotation. (transform beeing the bullet)

        GameObject collisionGameObject = collision.gameObject; //make a refrence to the GameObject it hits. called collisionGameObject
        if(collisionGameObject.name != "Player") //if the objects name is NOT equal to "Player" then
        {
            Debug.Log("ouchie 1");
            if (collisionGameObject.GetComponent<angystats>() != null) // if this object "doesn't not/does have" a "stattestmob" script then

            {
              
                collisionGameObject.GetComponent<angystats>().mobTakeDamage(plydmg); //call the function DealDamage in the stattestmob script of the object.
                Debug.Log("ouchie 2");
            }
        }
        Debug.Log("ouchie 0");


        Destroy(effect, 1f);// the effect in question will be visible for xf amount ofsecound
        Destroy(gameObject); //destroy object entierly
    }
}
