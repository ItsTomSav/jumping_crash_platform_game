using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SliderEff : MonoBehaviour
{
    [SerializeField] private Slider sliderEff;
    [SerializeField] private TextMeshProUGUI testoEff;

    void Start()
    {
        sliderEff.onValueChanged.AddListener((v2) =>{     //Ogni voltra che lo slider cambia prenderemo il valore e lo metteremo nel testo
        testoEff.text = v2.ToString("0");
        });

        testoEff.SetText(sliderEff.value.ToString());
    }
}
