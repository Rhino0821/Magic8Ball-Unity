using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using static UnityEngine.Rendering.VirtualTexturing.Debugging;

public class Magic8Ball : MonoBehaviour
{
    public TextMeshProUGUI answerText;
    public UnityEngine.UI.Slider optimismSlider;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && optimismSlider.value <= 0.5f)
        {
            int index2 = Random.Range(0, answerPositive.Length);

            answerText.text = answerPositive[index2];
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            int index = Random.Range(0, answerNegative.Length);

            answerText.text = answerNegative[index];
        }
    }

    private string[] answerNegative = { "No", "Nuh Uh", "Nah", "Leave Me Alone", };
    private string[] answerPositive = { "Yes", "Yer", "Yuh", "*magic*" };
}
