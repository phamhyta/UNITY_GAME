using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    public Movement Player;
    public TMP_Text score;
    
    void Update()
    {
        score.text = "Score: " + (Player.getScore()).ToString("F0");
    }
}
