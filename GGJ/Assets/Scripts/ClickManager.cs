using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

public class ClickManager : MonoBehaviour {
    private int index = 0;
    private bool typeText = false;

    private Organizer organizer;

    private List<Client> clients;
    public List<string> descriptions = new List<string>();
    public List<string> wrongSentences = new List<string>();
    public List<GameObject> btns = new List<GameObject>();
    public List<GameObject> facesImg = new List<GameObject>();
    public List<Sprite> sprites = new List<Sprite>();

    private void Start() {
        organizer = new Organizer(descriptions, wrongSentences, sprites, facesImg, btns);
        clients = organizer.Clients;

        clients[index].Face.SetActive(true);
        FindObjectOfType<DialogueManager>().StartDialogue(clients[index].Item.Text);
    }

    void Update() {
        if (Input.GetMouseButtonDown(0) && typeText) {
			FindObjectOfType<DialogueManager>().StartDialogue(clients[index].Item.Text);
            typeText = false;
		}
    }

    public void NextClient(Button btn) {
        if (clients[index].Item.Obj.name == btn.name) {
            clients[index].Face.SetActive(false);
            clients[index].Item.Obj.SetActive(false);

		Score.scoreValue += 10;
            
            index++;

            if (index == clients.Count) {
                SceneManager.LoadScene("EndScene");

            } else {
                typeText = false;
                clients[index].Face.SetActive(true);
                FindObjectOfType<DialogueManager>().StartDialogue(clients[index].Item.Text);

            }

        } else {
            FindObjectOfType<DialogueManager>().StartDialogue(clients[index].WrongText);
            typeText = true;
		Score.scoreValue -= 5;
        }
    }
}
