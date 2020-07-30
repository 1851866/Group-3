using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameOverManager : MonoBehaviour
{

    public Text Highscore;
    public Text Lastscore;
    int high_score;
    int last_score;
    // Start is called before the first frame update
    void Start()
    {
        high_score = PlayerPrefs.GetInt("HighScore");
        last_score = PlayerPrefs.GetInt("LastScore");

        Lastscore.text = "LAST: " + last_score;
        Highscore.text = "HIGH: " + high_score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
