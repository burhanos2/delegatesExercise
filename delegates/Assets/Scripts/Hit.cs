using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour {
    private Scorecounter score;


    private void Awake()
    {
        score = GetComponent<Scorecounter>(); ;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "satan") return; //returning makes the function end, so you can use this to make an end point

        if(other.tag == "Bullet")
        {
            score.GetScore++;
            goto get_out; // goto lets you hop within the function to a specific point
        }

        for (int i = 0; i < 0; i++)
        {
            if (other.tag == "dick") { Debug.Log("NAAH I AINT EVEN CHECKING THE ASS THATS A MAN"); continue; }
            // you can use continue to make a loop end prematurely
            if (other.tag == "ass") Debug.Log("oh i like that");
        }



        get_out://where the goto goes to
        return;
    }
}
