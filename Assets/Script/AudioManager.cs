using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;

    private void Awake ()
    {
        if(instance == null)   //Utilizziamo un'istanza per poter distruggere una sovrapposizione della musica
        {
            instance = this;
            DontDestroyOnLoad(gameObject);  //Con questo la musica non inizia ad ogni nuova scena
        }
        else
        {
            Destroy(gameObject);
        }
        
    }

    void Update()
    {
         if(SceneManager.GetActiveScene().name == "Finestra Finale")
        {
            Destroy(gameObject);
        }
    }

}
