using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{ 

    [SerializeField]   //makes it seen in inpector area
    Transform player;  //keeps track of player

    

    [SerializeField]
    float agroRange = 10;  //float called agroRange

    [SerializeField]
    float moveSpeed = 2;
    
    Rigidbody2D rb2d;   //calling the refrence to Rigidbody rb2d

    
    

    // Start is called before the first frame update
    void Start()
    {
        

        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
        

        float distToPlayer = Vector2.Distance(transform.position, player.position);
        // print("distToPlayer:" + distToPlayer);

        if (distToPlayer < agroRange)
        {

            player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>(); //will make this gameobject ''fixate on object with ''player'' tag in unity

            if (Vector2.Distance(transform.position, player.position) > 2.5)
            {
                transform.position = Vector2.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime); //will make this objects position move towards the ''player'' '' Timedeltatime makesmakes this run at a fixed time rahter than for you fps
            }   //Chase player mechanic

        }






    }

    
}

