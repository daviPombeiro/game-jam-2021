using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public Text dialogueText;

    public void StartDialogue (string dialogue) {
        StopAllCoroutines();
        StartCoroutine(TypeSentence(dialogue));
    }

    IEnumerator TypeSentence (string sentence) {
        dialogueText.text = "";
        foreach(char letter in sentence.ToCharArray()) {
            dialogueText.text += letter;
            yield return new WaitForSeconds(0.04f);
        }
    }

}
