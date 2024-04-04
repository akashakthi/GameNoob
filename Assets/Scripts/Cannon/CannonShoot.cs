using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonShoot : MonoBehaviour
{
    private CannonAmmo cannonAmmo;

    public GameObject cannonBallPrefabs;
    public Transform cannonShotPoint;
    public float shootForce;

    private void Awake()
    {
        cannonAmmo = GetComponent<CannonAmmo>();
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        if (cannonAmmo.CurrentAmmo <= 0) return;
        GameObject canonBall = Instantiate(cannonBallPrefabs, cannonShotPoint.position, cannonShotPoint.rotation);
        canonBall.GetComponent<Rigidbody>().AddForce(canonBall.transform.forward  * shootForce, ForceMode.Impulse);
        cannonAmmo.CurrentAmmo--;
    }
}
