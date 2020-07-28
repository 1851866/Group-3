using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretControl : MonoBehaviour
{
    public Transform turretBody;
    public Transform turretGun;

    public float turnSpeed;
    public float maxLeftRotate;
    public float maxRightRotate;
    public float maxHeight;
    public float minHeight;

    private float sideAngle = 0;
    private float verticalAngle = 0;

    private void Update()
    {
        RotateTurret();
    }

    private void RotateTurret()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            sideAngle += turnSpeed;
        }

        if (Input.GetAxis("Horizontal") < 0)
        {
            sideAngle -= turnSpeed;
        }

        if (Input.GetAxis("Vertical") > 0)
        {
            verticalAngle += turnSpeed;
        }

        if (Input.GetAxis("Vertical") < 0)
        {
            verticalAngle -= turnSpeed;
        }

        verticalAngle = Mathf.Clamp(verticalAngle, minHeight, maxHeight);
        sideAngle = Mathf.Clamp(sideAngle, maxLeftRotate, maxRightRotate);
        turretBody.eulerAngles = new Vector3(verticalAngle, sideAngle, 0);
    }

}
