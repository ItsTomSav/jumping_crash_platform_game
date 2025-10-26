using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GiocoInPausa = false;

    public GameObject pauseMenuUI;

    public int entra;

    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Escape))     //Serve solo per il bottone ESC. Quando viene premuto 2 volte (la prima per aprire, la seconda per chiudere)
       {
        if (GiocoInPausa)  //Se premo ESC e se sto già in pausa --> devo continuare il livello
        {
            Continua();
        }else              //Se premo ESC e sto giocando --> devo entrare nel menu,
        {
            Pausa();     
        }
       }
    }

    public void Continua()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GiocoInPausa = false;
    }

    void Pausa()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GiocoInPausa = true;
    }

    public void LoadMenuPrinc()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Finestra Iniziale");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
