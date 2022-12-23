using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;

    public Queue<string> sentences;
    public Queue<string> names;

    void Start()
    {
        sentences = new Queue<string>();
        names = new Queue<string>();
        gameObject.SetActive(false);
    }

    public void StartDialogue(Dialogue dialogue){
        gameObject.SetActive(true);
        sentences.Clear();

        foreach (string sentence in dialogue.sentences) {
            sentences.Enqueue(sentence);
        }
        foreach (string name in dialogue.names) {
            names.Enqueue(name);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence (){
        if (sentences.Count == 0){
            EndDialogue();
            return;
        }

        nameText.text = names.Dequeue();
        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence (string sentence) {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray()) {
            dialogueText.text += letter;
            yield return null;
        }
    }

    void EndDialogue(){
        gameObject.SetActive(false);
    }
}
