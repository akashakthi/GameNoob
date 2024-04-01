using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerHealth : MonoBehaviour
{
    public Image imageHealth;
    private int hp;


    public int HP {  
        
        get 
        { 
            return hp; 

        } 
        
  
        set 
        {  
            hp = value;
            print("Show Particle blood");
            print("Play AnimationHurt");
            print("Current HP " + hp);

        
        } 
    }
    // Start is called before the first frame update
    void Start()
    {
        hp = 100;
    }

    public void takeDamage()
    {
        hp -= 20;
    }
    // Update is called once per frame
    void Update()
    {
        imageHealth.fillAmount = (float) hp / 100;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            takeDamage();
        }
    }
}
