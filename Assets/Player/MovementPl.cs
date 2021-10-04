using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementPl : MonoBehaviour
{
    public Camera cammy;
    /*
    Transform my;
    Rigidbody2D body;*/

    
    private void Awake()
    {
        /*
        cam = Camera.main;
        my = GetComponent<Transform>();
        body = GetComponent<Rigidbody2D>();*/
        
    }
    

    
    
    public float moveSpeed;
    public Rigidbody2D rb;
    private Vector2 moveDirection;

    //public Camera cammy; //making refrence for camera
    Vector2 mousepos; //store mouseposition ffunction in mousepos

    // Update is called once per frame
    void Update()
    {
        /*
        //Distance from camera to object. We need this to get the proper calculation.
        float camDis = cam.transform.position.y - my.position.y;
        float yposplaya = my.transform.position.y;
        float xposplaya = my.transform.position.x;
        //get the mouse position in world space. using camDis for the Z axis.
        Vector3 mouse = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, camDis));

        float AngleRad = Mathf.Atan2(mouse.y - my.position.y, mouse.x - my.position.x);
        float angle = (180 / Mathf.PI) * AngleRad;

        body.rotation = angle;
        */
        

        ProcessInputs();
        //mousepos = cammy.ScreenToWorldPoint(Input.mousePosition);
        mousepos = cammy.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10)); // mouse pos ref fuction. cam ref camera.(ScreenToWorldPoint) changing mouse posistion from pixel cordinates to world units
        //cammy before ScreenToWorld
    }/*
    private void FixedUpdate()
    {
        Move();
    */
     private void FixedUpdate()
     {
         Move();

         Vector2 LookDir = mousepos - rb.position; //create vector 2 fuction called lookdir using mousepos minus player position. this makes a vector that points from 1 to the other.
        

         float angle = Mathf.Atan2(LookDir.y, LookDir.x) * Mathf.Rad2Deg -90f; // makes a angle out of the vector we made in LookDir. f.eks: angle from X-axis to the "line" between player and mouse. Atan2 returns angle in radius/radianse?, so have to ad Mathf to change it to Degrees
         //this makes our character spin like crazy, because we have camera attached to player. Fix new camera setting before proseeding
         rb.rotation = angle;
     }


    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY).normalized; 
    }


    void Move()
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }

}
