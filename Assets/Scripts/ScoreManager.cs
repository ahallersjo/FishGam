using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour {

    public static int score;
    private TextMeshProUGUI actualscore;
    private void Start()
    {
        actualscore = GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        actualscore.SetText("Score =" + score + ":");
    }

}
