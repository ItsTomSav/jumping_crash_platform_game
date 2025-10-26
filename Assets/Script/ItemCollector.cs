using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ItemCollector : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI testoMonete;
    [SerializeField] TextMeshProUGUI testoMonColl;

    //Audio
    [SerializeField] AudioSource collectionSound;

    //Immagini Stelle
    public GameObject stellaPiena1;
    public GameObject stellaPiena2;
    public GameObject stellaPiena3;


    public int monete = 0;
       private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Moneta"))
        {
            Destroy(other.gameObject);
            monete++;
            testoMonete.text = "Monete: " + monete;
            collectionSound.Play();
        }


        //Per dare le stelle al giocatore a fine livello     
        if (other.gameObject.CompareTag("Moneta"))
        {  
        if (monete < 3){
            Debug.Log(monete);
            stellaPiena1.SetActive(true);
        }
        else if (monete > 2 && monete <6)
        {
            stellaPiena1.SetActive(true);
            stellaPiena2.SetActive(true);
        }
        else
        {
            stellaPiena1.SetActive(true);
            stellaPiena2.SetActive(true);
            stellaPiena3.SetActive(true);
        }
        }
        testoMonColl.text = "Monete collezionate: " + monete + "/6";
    }
    
}
