﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class restart : MonoBehaviour {

    public Button btn;

	// Use this for initialization
	void Start () {
        btn.onClick.AddListener(TaskOnClick);
    }
	
    private void TaskOnClick()
    {
        SceneManager.LoadScene(0);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            SceneManager.LoadScene(0);
        }
    }

}
