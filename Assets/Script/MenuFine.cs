using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuFine : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
    }

    public void MenuIniziale()
    {
        SceneManager.LoadScene("Finestra Iniziale");
    }
}
