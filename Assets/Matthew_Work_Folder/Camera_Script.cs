using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Script : MonoBehaviour
{
    public float _MouseSensitivity;
    public float _LerpTime;

    public Transform Player_Transform;

    float xRot;

    public GameObject Player;
    public bool isCrounching;

   

    void Start()
    {
        Player_Transform = GameObject.FindGameObjectWithTag("Player").transform;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Player = GameObject.FindGameObjectWithTag("Player");
    }

    
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * _MouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * _MouseSensitivity * Time.deltaTime;

        xRot -= mouseY;
        xRot = Mathf.Clamp(xRot, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRot, 0f, 0f);
        Player_Transform.Rotate(Vector3.up * mouseX);

        //isCrounching = Player.GetComponent<Player_Controller_Script>().isCrouching;

        if (isCrounching)
        {
            transform.localPosition = Vector3.Lerp(transform.localPosition, new Vector3(transform.localPosition.x,0,transform.localPosition.z), _LerpTime * Time.deltaTime);
                
        }
        else
        {
            transform.localPosition = Vector3.Lerp(transform.localPosition, new Vector3(transform.localPosition.x, 1.68f, transform.localPosition.z), _LerpTime * Time.deltaTime);
        }

        ChangeMouseSensitivity();
    }



    public IEnumerator CameraShake (float _duration, float _magnitude)
    {
        Vector3 originalPos = transform.localPosition;

        float elapsed = 0.0f;

        while(elapsed < _duration)
        {
            float x = Random.Range(-1f, 1f) * _magnitude;
            float y = Random.Range(-1f, 1f) * _magnitude;

            transform.localPosition = new Vector3(x, y, originalPos.z);

            elapsed += Time.deltaTime;

            yield return null;
        }

        transform.localPosition = originalPos;
    }


    public void ChangeMouseSensitivity()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            _MouseSensitivity += 10;
        }
        if (Input.GetKeyDown(KeyCode.Y))
        {
            _MouseSensitivity -= 10;
        }
    }
}
