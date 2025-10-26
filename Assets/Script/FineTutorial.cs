using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FineTutorial : MonoBehaviour
{

    public GameObject tutorialFinitoUI;

    //Audio
    [SerializeField] AudioSource fineSound;

    

   private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Giocatore")
        {
            tutorialFinitoUI.SetActive(true);
            Time.timeScale = 0f;

            //Audio
            fineSound.Play();
        }
    }

    //Bottoni
    public void PrimoLivello()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Livello01");
    }
    
    public void Ripeti()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
