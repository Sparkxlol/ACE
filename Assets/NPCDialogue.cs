using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCDialogue : MonoBehaviour
{
    private DialogueManager dialogueManager;

    // Start is called before the first frame update
    void Start()
    {
        dialogueManager = GameObject.FindGameObjectWithTag("UIManager").GetComponent<DialogueManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            dialogueManager.SetNPCTextboxVisibility(true);
            dialogueManager.EditNPCTextbox("Hello, I'm Chopper!");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            dialogueManager.SetNPCTextboxVisibility(false);
        }
    }
}
