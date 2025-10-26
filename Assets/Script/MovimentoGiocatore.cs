using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoGiocatore : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float movementSpeed = 6f;
    [SerializeField] float jumpForce = 5f;

    //Groud check
    [SerializeField] Transform groundCheck;
    [SerializeField] LayerMask ground; //ground è il layer creato nel prefab del pavimento

    //Audio
    [SerializeField] AudioSource jumpSound;
    

    
    void Start()
    {
        rb =  GetComponent<Rigidbody>();  
    }

    
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");  //x - - Destra e Sinistra
        float verticalInput = Input.GetAxis("Vertical");  //z - - Avanti e Indietro

        rb.velocity = new Vector3(horizontalInput * movementSpeed, rb.velocity.y, verticalInput * movementSpeed);

        // Salto - - y
        if(Input.GetButtonDown("Jump") && isGrounded())
        {
            Jump();
        }
        
    }

    void Jump()
    {
        rb.velocity = new Vector3(rb.velocity.x, jumpForce, rb.velocity.z);
        jumpSound.Play();
    }

    //Verifichiamo se il giocatore entra in contatto con la testa del nemico
     private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Testa Nemico"))
        {
            Destroy(collision.transform.parent.gameObject);  //Distruggiamo il nemico. Mettiamo transform perchè non vogliamo solo distruggere la Testa del Nemico ma anche il padre (Corpo Nemico)
            Jump();
        }
    }

    // Verifichiamo che il giocatore tocchi terra per farlo saltare solo quando è a terra e non nel vuoto
    bool isGrounded(){
        return Physics.CheckSphere(groundCheck.position, 0.1f, ground);  //0.1f è il raggio della sfera, ground è il layer.
        //isGrounded è vero quando CheckSphere è vero. CheckSphere è vero quando la sfera è nel piano
    }
    


    
}
