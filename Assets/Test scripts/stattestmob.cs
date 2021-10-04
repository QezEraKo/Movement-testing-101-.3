using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stattestmob : MonoBehaviour
{

    //NOT IN USE
    public int mdamage;
    public int mhp;
    public stattestplay playdamage;
    public GameObject ptestObj; //adding this to make bool

    private int plydmg; //used as refrence for pdamage, witch is in stattestplay
    private stattestplay ScriptAccess; // this is used to get access to stattestplay script.
    [SerializeField]
    private int maxHealth;



    // Start is called before the first frame update
    void Start()
    {
        maxHealth = 100;
        mhp = maxHealth;

        mdamage = 5;

        DealDamage(plydmg);
        
    }


    // Update is called once per frame
    void Update()
    {
        if (ptestObj != null)
        {
            ScriptAccess = playdamage.GetComponent<stattestplay>();

            plydmg = ScriptAccess.pdamage;
        }
    }

    public void DealDamage(int Plydmg)
    {
        mhp -= (plydmg);
    }

    

}
