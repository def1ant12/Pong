﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToMainScene : MonoBehaviour
{
    public void OnButtonPressed()
    {
        SceneManager.LoadScene("Main");
    }
}