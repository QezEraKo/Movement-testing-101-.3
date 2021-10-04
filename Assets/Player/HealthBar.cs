using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //using UI library

public class HealthBar : MonoBehaviour
{

    public Slider slider; //makes a public fuction of ''Slider'' from UI library called slider
   // public Text healthText;


    public void SetMaxHealth(int health)  //using public to call from other scripts
    {
        slider.maxValue = health;
        slider.value = health;
    }
        

    public void SetHealth(int health)
    {
        slider.value = health;
    }

    

}
