using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour {
    public void Play(){
        SceneManager.LoadScene("GameScene");
    }
    public void Restart() {
        SceneManager.LoadScene("StartScene");
    }
    
}
