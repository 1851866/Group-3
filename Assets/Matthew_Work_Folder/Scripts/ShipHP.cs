using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShipHP : MonoBehaviour
{
    public int maxHealth;
    public Text hpText;

    public int currentHealth;

    public LevelManager LM;
    public Camera_Script CS;

    public float ShakeMagnitude;
    public float ShakeDuration;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(currentHealth);
        if (hpText != null)
        {
            hpText.text = "HP: " + currentHealth;
        }
        if (currentHealth<= 0)
        {
            LM.GameOver();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            currentHealth--;
            Destroy(other.gameObject);
            CS.CallShake(ShakeDuration, ShakeMagnitude);
        }
        
    }
}
