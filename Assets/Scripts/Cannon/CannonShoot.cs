using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonShoot : MonoBehaviour
{
    public GameObject cannonBallPrefabs;
    public Transform cannonShootPoint;
    public float shootForce;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot () 
    {
        GameObject cannonball = Instantiate(cannonBallPrefabs, cannonShootPoint.position, cannonShootPoint.rotation);
        cannonball.GetComponent<Rigidbody>().AddForce(cannonball.transform.forward * shootForce, ForceMode.Impulse);
    }
}
