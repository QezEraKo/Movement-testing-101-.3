using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootermovement : MonoBehaviour
{
    
    public float moveSpeed;
    public float stoppingDistance;
    public float retreatDistance;
    public float pullRange;
    public Transform player;

    void Start()
    {

        player = GameObject.FindGameObjectWithTag("Player").transform; //will find distance between player and shooter

    }

    // Update is called once per frame
    void Update()
    {

            if (Vector2.Distance(transform.position, player.position) < pullRange && Vector2.Distance(transform.position, player.position) > stoppingDistance) //if distance between player-mob is lower than ''pullRange'' and higer than ''stoppingDistance'' then
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, moveSpeed * Time.deltaTime); //move this objects position closer to ''player'' position at sertain speed on fixed time
        }


        else if (Vector2.Distance(transform.position, player.position) < stoppingDistance && Vector2.Distance(transform.position, player.position) > retreatDistance) // but if distance between player-mob is lower than stopping distance and higher than retreat distance then
        {
            transform.position = this.transform.position; //make object move towards own location 
        }
        else if(Vector2.Distance(transform.position, player.position) < retreatDistance) //and if player-mob distance is lower than retreat distance, then
        {
            transform.position = Vector2.MoveTowards(transform.position, player.position, -moveSpeed * Time.deltaTime); //make object move towards player position with minus speed(moving away) at fixed time
        }




    }
}
