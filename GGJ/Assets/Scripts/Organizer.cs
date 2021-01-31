using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Organizer {
    private List<Item> items = new List<Item>();
    private List<Client> faces = new List<Client>();
    private List<Client> clients = new List<Client>();

    private int index1, index2;

    public Organizer (List<string> descriptions, List<string> wrongSentences, List<Sprite> sprites,
    List<GameObject> facesImg, List<GameObject> btns) {
        for(int a = 0; a < facesImg.Count; a++){
            faces.Add(new Client(facesImg[a], wrongSentences[a]));
            faces[a].Face.SetActive(false);
        }

        while (sprites.Count > 0 && btns.Count > 0) {
            index1 = Random.Range(0, sprites.Count);
            index2 = Random.Range(0, btns.Count);

            btns[index2].GetComponent<Image>().sprite = sprites[index1];

            items.Add(new Item(descriptions[index1], btns[index2]));

            sprites.RemoveAt(index1);
            descriptions.RemoveAt(index1);
            btns.RemoveAt(index2);
        }

        while (faces.Count > 0 && items.Count > 0) {
            index1 = Random.Range(0, items.Count);
            index2 = Random.Range(0, faces.Count);

            faces[index2].Item = items[index1];
            clients.Add(faces[index2]);

            items.RemoveAt(index1);
            faces.RemoveAt(index2);
        }
    }

    public List<Client> Clients {
        get => clients;
        set => clients = value;
    }
}
