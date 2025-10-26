using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class VitaGiocatore : MonoBehaviour
{

    bool dead = false;


    //Countdown
    [SerializeField] TextMeshProUGUI testoCountdown;
    [SerializeField] float tempoRimanente;
    [SerializeField] AudioSource timerSound;
    bool timer = false;
    public int entra = 0;


    //Audio
    [SerializeField] AudioSource deathSound;

    private void Update()
    {
        if (transform.position.y < -2f && !dead)
        {
            Die();
            
        }


        //Countdown
        if (tempoRimanente > 0)
        {
            tempoRimanente -= Time.deltaTime;
        }                                          //Usiamo l'if per far fermare a 0:00 il countdown e non andare oltre (Ad esempio -1:-23)
        else if (tempoRimanente < 0)
        {
            tempoRimanente = 0;
            Die();
        }

        Suona();

        int minuti = Mathf.FloorToInt(tempoRimanente / 60);
        int secondi = Mathf.FloorToInt(tempoRimanente % 60);  //la % è l'operatore modulo (Ad esempio 5/3 è 1 con resto 2, la % mi da 2)
        testoCountdown.text = string.Format("{0:00}:{1:00}", minuti, secondi);
        
        //Se il countdown finisce, il giocatore muore

       //Se premo ESC il suono del timer si deve stoppare e se premo di nuvo ESC (ritornando al gioco) il suono del timer si deve riavviare

       if (Input.GetKeyDown(KeyCode.Escape))     
       {
        if (PauseMenu.GiocoInPausa)  //Se premo ESC e se sto già in pausa --> devo continuare il livello, quindi riattivo il suono del timer
        {
            entra=0;
        }else              
        {
            timerSound.Pause();   //Se premo ESC e sto giocando --> devo entrare nel menu, quindi stoppo il suono del timer
        }

       }


    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Corpo Nemico"))
        {
            Die();
        }
    }

    //Esiste un modo per far "morire" il giocatore con il metodo Destroy(), ma vogliamo che il giocatore respawni di nuovo all'inizio del livello. 
    //Bisogna quindi farlo sparire. Utilizziamo il MeshRenderer, Kinematic e il file script MovimentoGiocatore
    void Die()
    {
        GetComponent<MeshRenderer>().enabled = false;  //Togliamo il tick dal MeshRender
        GetComponent<Rigidbody>().isKinematic = true;  //Attiviamo il "Kinematic" cosi da bloccare il giocatore
        GetComponent<MovimentoGiocatore>().enabled = false;  //Disabilitiamo lo script MovimentoGiocatore

        //Accessori Giocatore
        GameObject[] objects = GameObject.FindGameObjectsWithTag("AccessoriGiocatore");
            foreach(GameObject obj in objects)
            {
                obj.GetComponent<MeshRenderer>().enabled = false;
            }



        //Ricarico il livello
        Invoke(nameof(RicaricaLivello), 1.3f);  //Invece di richiamare semplicemente il metodo, utiliziamo Invoke per aggiungere un piccolo ritardo.
        dead = true;
        deathSound.Play();

        
    }

    //Creiamo un metodo per ricaricare il livello. Per far questo dobbiamo accedere al Unity Manager: aggiungiamo all'inizio del codice la riga 4
    void RicaricaLivello()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    void Suona(){

        if(tempoRimanente < 6 && entra == 0)
        {
            entra++;
            timer = true;
            testoCountdown.color = Color.red;
        }

        if (timer && entra==1)  // Se è vero
        {
            timerSound.Play();
            timer = false;
        }
    }

    

    

}
