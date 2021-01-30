using UnityEngine;
using System.Collections;
using System;

public class Item {
    private GameObject obj;
    private string text;

    public Item (string newText, GameObject newObj) {
        text = newText;
        obj = newObj;

    }

    public string Text {
        get => text;
        set => text = value;
    }

    public GameObject Obj {
        get => obj;
        set => obj = value;
    }
}
