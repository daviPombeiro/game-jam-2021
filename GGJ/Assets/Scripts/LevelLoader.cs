using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;
    public void Play(){
        StartCoroutine(LoadLevel("GameScene"));
    }

    public void Credits(){
        StartCoroutine(LoadLevel("CreditsScene"));
    }
    public void Restart() {
        StartCoroutine(LoadLevel("StartScene"));
        Score.scoreValue = 0;
    }

    IEnumerator LoadLevel(string levelName){
        // Play animatioin
        transition.SetTrigger("Start");

        // Wait
        yield return new WaitForSeconds(1f);

        //Load scene
        SceneManager.LoadScene(levelName);

    }
}
