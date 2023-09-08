using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    private GameObject textboxObject;
    private TextMeshProUGUI textbox;

    // Start is called before the first frame update
    void Start()
    {
        textboxObject = GameObject.FindGameObjectWithTag("UI").transform.GetChild(0).gameObject;
        textbox = textboxObject.GetComponentInChildren<TextMeshProUGUI>();
        textbox.SetText("BRUH");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EditNPCTextbox(string text)
    {
        textbox.SetText(text);
    }

    public void SetNPCTextboxVisibility(bool visible)
    {
        textboxObject.SetActive(visible);
    }
}
