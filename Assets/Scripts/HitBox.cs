﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBox : MonoBehaviour {
    
    public bool ColPossible;

    // Use this for initialization
    void Start () {
        ColPossible = false;
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (other.GetComponent<PlayerController>().ColPossible == true && ColPossible == true)
            {
                other.GetComponent<PlayerController>().ColHitbox();

                if (gameObject.tag == "monster")
                if (gameObject.GetComponent<MonsterController>().isDisabler)
                {
                    other.GetComponent<PlayerController>().Slow(Random.Range(10.0f, 30.0f), Random.Range(1.0f, 3.0f));
                    gameObject.GetComponent<MonsterController>().isDisabler = false;
                }

            }
        }
    }
}
