using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercoat : MonoBehaviour
{
    //public GameObject ptestObj;
    public stattestplay playdamage;
    public GameObject mtestObj;
    //[serializeField]
    //GameObject Mdmgcalc; // <--- added to run script from stattestmob on mtestObj. 

    private stattestplay ScriptAccess;
    private int plydmg; // <-- make an integer named plydmg that we use later.

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)  //on player collision
    {
        if (mtestObj != null)
        {
            if (col.gameObject == (mtestObj))
            {
           

                
               
                Debug.Log("test player collided with mob");
            }
        }
        //run  DealDamage() //run script from stattestmob
    }

    // Update is called once per frame
    void Update()
    {
        // if (ptestObj != null)     will test this trough stattestmob and stattestplay
        // {
        //     ScriptAccess = playdamage.GetComponent<stattestplay>();  will test this trough stattestmob and stattestplay
        //
        //     plydmg = ScriptAccess.pdamage;       will test this trough stattestmob and stattestplay
        // }
    }

    




}
