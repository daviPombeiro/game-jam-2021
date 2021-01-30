using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Organizer {
    private List<Item> items = new List<Item>();
    private List<Client> faces = new List<Client>();
    private List<Client> clients = new List<Client>();

    private int index1, index2;

    public Organizer (List<string> descriptions, List<string> wrongSentences, List<GameObject> objs,
    List<GameObject> facesImg) {
        items.Add(new Item(descriptions[0], objs[0]));
        items.Add(new Item(descriptions[1], objs[1]));
        items.Add(new Item(descriptions[2], objs[2]));

        faces.Add(new Client(facesImg[0], wrongSentences[0]));
        faces.Add(new Client(facesImg[1], wrongSentences[1]));
        faces.Add(new Client(facesImg[2], wrongSentences[2]));

        for (int i = 0; i < faces.Count; i++) {
            faces[i].Face.SetActive(false);
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
