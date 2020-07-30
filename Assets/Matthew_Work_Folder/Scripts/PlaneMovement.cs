using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMovement : MonoBehaviour
{
    public GameObject targetPath;
    public float planeSpeed;

    // Start is called before the first frame update
    void Start()
    {
        targetPath = GameObject.FindGameObjectWithTag("Target");
        transform.LookAt(targetPath.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<Rigidbody>().AddForce(transform.forward * planeSpeed * Time.deltaTime);
    }
}
