using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class UI_Manager : MonoBehaviour
{
    public Text Score_Text;
    public Text HP_Text;

    int score_High_I;
    int hp_I;
    int score_I;

    public ShipHP Ship_hp;

    // Start is called before the first frame update
    void Start()
    {
        Score_Tracker_Script._TotalScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        hp_I = Ship_hp.currentHealth;
        score_I = Score_Tracker_Script._TotalScore/2;

        Score_Text.text = "Kills: " + score_I;//sloppy fix

        HP_Text.text = "HP: " + hp_I;


        score_High_I = PlayerPrefs.GetInt("HighScore");
        PlayerPrefs.SetInt("LastScore", score_I);
        if (score_I > score_High_I)
        {
            PlayerPrefs.SetInt("HighScore", score_I);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            PlayerPrefs.SetInt("HighScore", 0);
        }

    }
}
