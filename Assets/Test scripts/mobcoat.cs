using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mobcoat : MonoBehaviour
{
    public GameObject ptestObj;
    public stattestmob mobdamage;

    //    private int pdmg;
    //
    //      public int getpdmg{
    //      return pdm }

    private stattestmob ScriptAccess;
    private int mobdmg;   //<-- make an integer named mobdmg that we use later.
    //private playercoat player;  //NEW NEW NEW



    // Start is called before the first frame update
    void Start()
    {
        
        
        
    }



    void OnCollisionEnter2D(Collision2D col)  //on player collision
    {
        if (ptestObj != null)
        {
            if (col.gameObject == (ptestObj))
            {
               
                
                
                Debug.Log("test mob collided with player");
            }
        }
        //run  DealDamage() //run script from stattestmob
    }

    // Update is called once per frame
    void Update()
    {
        
        
        





        //if (mtestObj != null)
        //{
         //   ScriptAccess = mobdamage.GetComponent<stattestmob>();

           // mobdmg = ScriptAccess.mdamage;
        //}
    }
}
