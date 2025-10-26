using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PallaCannone : MonoBehaviour
{
    public float speedPalla;
    public float life = 3f;
    Rigidbody rbp;

    void Awake()
    {
        Destroy(gameObject, life);
    }

    void Start()
    {
        rbp = GetComponent<Rigidbody>();
        rbp.velocity = transform.right * speedPalla;
    }
}
