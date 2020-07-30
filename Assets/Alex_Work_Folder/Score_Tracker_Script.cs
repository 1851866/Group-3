using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score_Tracker_Script : MonoBehaviour
{
   public static int _TotalScore;

   public static int _PlaneValue = 1;

  

    public static void IncreaseScore()
    {
        _TotalScore = _TotalScore + _PlaneValue;
    }
}
