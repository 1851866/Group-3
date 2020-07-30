using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretControl : MonoBehaviour
{
    public Transform turretBody;
    public Transform turretGun;

    public float turnSpeed;
    public float verticalSpeed;
    public float maxLeftRotate;
    public float maxRightRotate;
    public float minDownRotate;
    public float maxUpRotate;

    private float sideAngle = 0;
    private float verticalAngle = 180;

    public AudioSource rotateSound;

    private void Start()
    {
        maxLeftRotate *= -1;
        minDownRotate += turretGun.localEulerAngles.y;
        maxUpRotate = turretGun.localEulerAngles.y - maxUpRotate;
    }

    private void Update()
    {
        RotatetheTurret();
    }

    private void RotatetheTurret()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            sideAngle += turnSpeed;
            rotateSound.enabled = true;
        }

        if (Input.GetAxis("Horizontal") < 0)
        {
            sideAngle -= turnSpeed;
            rotateSound.enabled = true;
        }

        if (Input.GetAxis("Vertical") > 0)
        {
            verticalAngle -= verticalSpeed;
            rotateSound.enabled = true;
        }

        if (Input.GetAxis("Vertical") < 0)
        {
            verticalAngle += verticalSpeed;
            rotateSound.enabled = true;
        } 

        if(Input.GetAxis("Horizontal") == 0 && Input.GetAxis("Vertical") == 0)
        {
            rotateSound.enabled = false;
        }

        verticalAngle = Mathf.Clamp(verticalAngle, maxUpRotate, minDownRotate);
        sideAngle = Mathf.Clamp(sideAngle, maxLeftRotate, maxRightRotate);
        turretBody.eulerAngles = new Vector3(0, sideAngle, 0);
        turretGun.localEulerAngles = new Vector3(0, verticalAngle, 0);
    }

}
