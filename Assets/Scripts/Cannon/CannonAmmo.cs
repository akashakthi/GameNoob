using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class CannonAmmo : MonoBehaviour
{
    public TextMeshProUGUI ammoText;
    public int totalAmmo;
    public int currentAmmo;

    public int CurrentAmmo
    {
        get 
        {
            return currentAmmo; 
        }
        set 
        { 
            currentAmmo = value;
            ammoText.text = "Current Ammo " + currentAmmo + " / " + totalAmmo;
            print("current Ammo = " +currentAmmo); 
        }
    }
    void Start()
    {
        CurrentAmmo = totalAmmo;
    }

}
