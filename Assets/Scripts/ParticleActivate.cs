using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleActivate : MonoBehaviour
{

    public ParticleSystem smokeParticleSystem;
    public GameObject sceneLoader;
    private SceneLoader loadingNextSceneObject;

    // Start is called before the first frame update
    void Start()
    {
        smokeParticleSystem.Stop();
    }

    void OnTriggerEnter2D(Collider2D other)
    {   
        smokeParticleSystem.Play();
        print("Sending Loading Instruction");
        loadingNextSceneObject = sceneLoader.GetComponent<SceneLoader>();
        loadingNextSceneObject.levelComplete = true;
        Debug.Log("You won!");  
    }
}
