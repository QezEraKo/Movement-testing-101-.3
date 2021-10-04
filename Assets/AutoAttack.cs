using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoAttack : MonoBehaviour
{
    //on the fiwwa bawl, I put collision Detectiion to Continious to make it detect better is higher speeds.
    //Chose to Freeze the rotation and remove gravity, since that fit my game better


    public Transform firePoint;
    public GameObject bulletPrefab;

    public float bulletForce = 20f;



    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")) //Fire 1 is Mouse 0 (left click)
        {
            shoot();
        }
    }


    void shoot ()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation); //instantiate "bulletPrefab-> GameObject. At firepint position ->Transform firePoint. Set the rotation to its own rotation.
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>(); //Make a fuction called RB stored as Rigidbody 2D, get the component <Rigidbody2D> from the object the bullet is on.
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse); // we add force to the rb the bullet is attached to.
    }


}




