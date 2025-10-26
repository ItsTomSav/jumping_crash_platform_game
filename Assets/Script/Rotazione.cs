using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotazione : MonoBehaviour
{
    [SerializeField] float speedX;
    [SerializeField] float speedY;
    [SerializeField] float speedZ;
    
    void Update()
    {
        transform.Rotate(360 * speedX * Time.deltaTime, 360 * speedY * Time.deltaTime, 360 * speedZ * Time.deltaTime); //Completa rotazione (360) per velocià di rotazione per i frame/sec
    }
}
