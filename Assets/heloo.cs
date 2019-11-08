using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using TMPro;

public class heloo : MonoBehaviour
{
    private UnityEvent OnpressSpace;
    [SerializeField] private behaviourrr behav;
    [SerializeField] private Image img;
    [SerializeField] private TextMeshProUGUI text;


    // Start is called before the first frame update
    void Start()
    {
        OnpressSpace = new UnityEvent();
        OnpressSpace.AddListener(delegate { behav.ChangeColor(img); });
        OnpressSpace.AddListener(delegate { behav.Changetext(text); });
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            OnpressSpace.Invoke();
        }
    }
}
