using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PavimentoSticky : MonoBehaviour
{
    //Questo script ci serve per verificare che, se il giocatore si trova sul pavimento mobile, esso si deve muovere insieme ad esso.
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Giocatore")  //Se il Giocatore entra in contatto con il pavimento mobile, allora esso diventa "Figlio" dell'oggetto pavimento mobile
        {
            collision.gameObject.transform.SetParent(transform);
        }
    }

     private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.name == "Giocatore")  //Se il Giocatore non è in contatto con il pavimento mobile, allora esso non è più "Figlio" dell'oggetto pavimento mobile
        {
            collision.gameObject.transform.SetParent(null);
        }
    }
}
