using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public GameObject turretHead;

    public Transform firePoint1;
    public Transform firePoint2;

    public float bulletSpeed;
    public float fireRate;

    private bool firing = false;
    private Coroutine fireCoroutine;

    // Update is called once per frame
    void Update()
    {
        if (firing == false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                firing = true;
                fireCoroutine = StartCoroutine("continuousFire");
            }
        }
        if (firing == true)
        {
            if (Input.GetMouseButtonUp(0))
            {
                firing = false;
                StopCoroutine(fireCoroutine);
            }
        }
    }

    IEnumerator continuousFire()
    {
        while (true)
        {
            FireGun();
            yield return new WaitForSeconds(fireRate);
        }
    }

    private void FireGun()
    {
        GameObject bullet1 = Instantiate(bulletPrefab, firePoint1.position, Quaternion.identity) as GameObject;
        GameObject bullet2 = Instantiate(bulletPrefab, firePoint2.position, Quaternion.identity) as GameObject;
        bullet1.GetComponent<Rigidbody>().AddForce(bullet1.transform.forward * bulletSpeed);
        bullet2.GetComponent<Rigidbody>().AddForce(bullet2.transform.forward * bulletSpeed);
    }
}
