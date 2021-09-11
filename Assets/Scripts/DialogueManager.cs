using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

[System.Serializable]
public class Dialogue
{
    public string nombre;
    public string dialogue;
    public Sprite scene;
}
public class DialogueManager : MonoBehaviour
{
    public static DialogueManager instance;
    public TextMeshProUGUI dialogueText;
    public TextMeshProUGUI nombre;
    public Image SceneImage;
    public List<Dialogue> dialogue;
    public int index;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        ShowDialogue(dialogue[0]);
    }
    public void ShowDialogue(Dialogue dialogue)
    {
        nombre.text = dialogue.nombre;
        dialogueText.text = dialogue.dialogue;
        SceneImage.sprite = dialogue.scene;
    }
    public void NextDialogue()
    {
        index++;
        if (index >= dialogue.Count)
        {
            index = 0;
        }
        else
        {
            ShowDialogue(dialogue[index]);
        }
    }
}
