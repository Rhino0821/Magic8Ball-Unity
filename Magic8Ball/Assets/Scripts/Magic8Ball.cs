using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Magic8Ball : MonoBehaviour
{
    public TextMeshProUGUI answerText;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int index = Random.Range(0, answer.Length);
            
            answerText.text = answer[index];
        }
    }
    private string[] answer = { "Yes", "No", "Maybe", "Try Again", "Perchance", "Nah", "Leave Me Alone", "*magic*" };
}
