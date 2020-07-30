using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score_Tracker_Script : MonoBehaviour
{
    public float _TotalScore;

    public float _PlaneValue;

   public Text _TextScore;

    void Update()
    {
       _TextScore.text = _TotalScore.ToString();
    }

    public void IncreaseScore()
    {
        _TotalScore = _TotalScore + _PlaneValue;
    }
}
