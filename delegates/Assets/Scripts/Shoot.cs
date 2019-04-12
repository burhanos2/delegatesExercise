using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    public GameObject bullet;

    private void Update()
    {
        //simple
        if(Input.GetKeyDown(KeyCode.Space))
        { Instantiate(bullet, gameObject.transform); }
    }
}
