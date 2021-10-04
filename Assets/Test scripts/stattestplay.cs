using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stattestplay : MonoBehaviour
{

    // NOT IN USE


    public int pdamage;
    public int php;
    public GameObject ptestObj;
    [SerializeField]
    private int maxHealth;
    




    // Start is called before the first frame update
    void Start()
    {
        maxHealth = 50;
        php = maxHealth;
        pdamage = 10;
    }

    public void TakeDamage()
    {

        if (ptestObj != null)     //will test this trough stattestmob and stattestplay
        {


            //ScriptAccess = playdamage.GetComponent<stattestplay>();  will test this trough stattestmob and stattestplay

            //plydmg = ScriptAccess.pdamage;       will test this trough stattestmob and stattestplay
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
