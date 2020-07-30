using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Script : MonoBehaviour
{

    void Start()
    {
        Debug.Log(transform.localPosition.y);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("One");
           StartCoroutine(CameraShake(0.2f, 1f));
        }
    }

    public void CallShake(float _duration, float _magnitude)
    {
        StartCoroutine(CameraShake(_duration, _magnitude));
    }



    public IEnumerator CameraShake (float _duration, float _magnitude)
    {
        Debug.Log("Shake");
        Vector3 originalPos = transform.localPosition;

        float elapsed = 0.0f;

        while(elapsed < _duration)
        {
            float x = Random.Range(transform.localPosition.x-0.1f, transform.localPosition.x + 0.1f) * _magnitude;
            float y = Random.Range(transform.localPosition.y - 0.1f, transform.localPosition.y + 0.1f) * _magnitude;

            transform.localPosition = new Vector3(x, y, originalPos.z);

            elapsed += Time.deltaTime;

            yield return null;
        }

        transform.localPosition = originalPos;
    }

}
