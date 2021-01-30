using UnityEngine;
using System.Collections;
using System;

public class Client {
    private GameObject face;
    private Item item;
    private string wrongText;

    public Client (GameObject newFace, string newWrongText) {
        face = newFace;
        wrongText = newWrongText;
    }

    public GameObject Face {
        get => face;
        set => face = value;
    }

    public string WrongText {
        get => wrongText;
        set => wrongText = value;
    }

    public Item Item {
        get => item;
        set => item = value;
    }
}
