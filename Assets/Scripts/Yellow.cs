﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor.SceneManagement;

public class Yellow : MonoBehaviour
{
    float n;

    int num;

    public GameObject esc;
    public GameObject yellow;
    public GameObject config;

    // Use this for initialization
    void Start()
    {
        num = 2;
    }

    // Update is called once per frame
    void Update()
    {
        n += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.LeftArrow) && num > 1)
            num--;
        if (Input.GetKeyDown(KeyCode.RightArrow) && num < 3)
            num++;

        switch(num)
        {
            case 1:
                transform.localPosition = new Vector3(-150.0f, -215.0f, 0.0f);
                break;
            case 2:
                transform.localPosition = new Vector3(-14.0f, -215.0f, 0.0f);
                break;
            case 3:
                transform.localPosition = new Vector3(150.0f, -215.0f, 0.0f);
                break;
        }

        if (Input.GetKey(KeyCode.Return) || Input.GetKey(KeyCode.Space))
        {
            switch (num)
            {
                case 1:
                    Application.Quit();
                    Debug.Log("exit");
                    break;
                case 2:
                    SceneManager.LoadScene("Cartoon", LoadSceneMode.Single);
                    //GameManager.instance.FadeAndLoadScene("Cartoon");
                    break;
                case 3:
                    esc.SetActive(false);
                    yellow.SetActive(false);
                    config.SetActive(true);
                    break;
            }
        }
    }
}