using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SparoCannone : MonoBehaviour
{
    public Transform puntoDiFuoco;
    public GameObject proiettile;
    float timeBetween;
    public float statTimeBetween;

    [SerializeField] AudioSource sparo;



    void Start()
    {
        timeBetween = statTimeBetween;
    }

    
    void Update()
    {
        if(timeBetween <= 0)
        {
            Instantiate(proiettile, puntoDiFuoco.position, puntoDiFuoco.rotation);
            timeBetween = statTimeBetween;
            sparo.Play();
        }
        else
        {
            timeBetween -= Time.deltaTime;
        }
    }
}
