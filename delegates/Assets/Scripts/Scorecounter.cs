using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scorecounter : MonoBehaviour {
    public Text score;
    private int _score;

    public int GetScore
    { get { return _score; } set { _score = value; } }

    // Update is called once per frame
    void Update () {
        score.text = "SCORE: " + _score;
	}
}
