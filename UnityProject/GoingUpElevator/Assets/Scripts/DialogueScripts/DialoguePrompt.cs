using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialoguePrompt : MonoBehaviour
{
    public Dialogue dialogue;
    public DialogueManager manager;

    public void TriggerDialogue(){
        manager.StartDialogue(dialogue);
    }
}
