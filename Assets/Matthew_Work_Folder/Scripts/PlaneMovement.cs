using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMovement : MonoBehaviour
{
    public GameObject targetPath;
    public float planeSpeed;

    public AudioSource boomSound;

    // Start is called before the first frame update
    void Start()
    {
        targetPath = GameObject.FindGameObjectWithTag("Target");
        boomSound = GameObject.FindGameObjectWithTag("ExplosionSound").GetComponent<AudioSource>();
        transform.LookAt(targetPath.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Rigidbody>().AddForce(transform.forward * planeSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        //add partical stuffs here
        if(other.tag == "Bullet")
        {
            boomSound.Play();
            Destroy(this.gameObject);
        }
    }
}
