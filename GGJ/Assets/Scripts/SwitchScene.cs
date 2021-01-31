﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour {
    public void Play(){
        SceneManager.LoadScene("GameScene");
    }

    public void Credits(){
        SceneManager.LoadScene("CreditsScene");
    }
    public void Restart() {
        SceneManager.LoadScene("StartScene");
        Score.scoreValue = 0;
    }
    
}
