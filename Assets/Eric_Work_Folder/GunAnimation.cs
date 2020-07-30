using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunAnimation : MonoBehaviour
{
    // Start is called before the first frame update

    Animator Gun_A;
    public ParticleSystem Flash1;
    public ParticleSystem Flash2;
    void Start()
    {
        Gun_A = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Flash1.Play();
            Flash2.Play();
            Gun_A.SetInteger("Shoot", 1);
            //Debug.Log("Shooting");
        }

        if (Input.GetMouseButtonUp(0))
        {
            Gun_A.SetInteger("Shoot", 0);
        }

        else
        {
            //Gun_A.SetInteger("Shoot", 0);
        }

    }
}
