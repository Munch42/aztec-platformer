using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleActivate : MonoBehaviour
{

    public ParticleSystem smokeParticleSystem;

    // Start is called before the first frame update
    void Start()
    {
        smokeParticleSystem.Stop();
    }

    void OnTriggerEnter2D(Collider2D other)
    {   
        smokeParticleSystem.Play();
        Debug.Log("You won!");  
    }
}
