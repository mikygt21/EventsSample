using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class behaviourrr : MonoBehaviour
{
    public void Changetext(TextMeshProUGUI textUGUI)
    {
        textUGUI.text = "hola";
    }

    public void ChangeColor(Image img)
    {
        img.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }
}
