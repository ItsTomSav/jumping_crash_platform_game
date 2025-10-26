using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SliderMus : MonoBehaviour
{
    [SerializeField] private Slider sliderMus;
    [SerializeField] private TextMeshProUGUI testoMus;

    void Start()
    {
        sliderMus.onValueChanged.AddListener((v1) =>{     //Ogni volta che lo slider cambia prenderemo il valore e lo metteremo nel testo
        testoMus.text = v1.ToString("0");
        });

        testoMus.SetText(sliderMus.value.ToString());
    }
}
