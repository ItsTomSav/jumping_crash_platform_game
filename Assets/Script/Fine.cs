using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fine : MonoBehaviour
{

    public GameObject livelloFinitoUI;

    //Audio
    [SerializeField] AudioSource fineSound;

    

   private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Giocatore")
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);  Passa alla scena successiva

            livelloFinitoUI.SetActive(true);
            Time.timeScale = 0f;

            //Audio
            fineSound.Play();
        }
    }

    //Bottoni
    public void LivSuccessivo()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
    
    public void Riprova()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
