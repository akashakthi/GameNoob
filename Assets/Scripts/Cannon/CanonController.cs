using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonController : MonoBehaviour
{
    public float rotationSpeed;
    public float Xdegrees, Ydegrees;

    public Transform cannonBody;
    // Update is called once per frame
    void Update()
    {
        CannonMovement();
    }

    void CannonMovement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Xdegrees += horizontalInput * rotationSpeed * Time.deltaTime;
        Ydegrees += verticalInput * rotationSpeed * Time.deltaTime;

        Xdegrees = Mathf.Clamp(Xdegrees, -43, 43);
        Ydegrees = Mathf.Clamp(Ydegrees, -7, 48);
        cannonBody.localEulerAngles = new Vector3(0, Ydegrees, Xdegrees);
    }
}
