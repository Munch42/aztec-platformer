using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public bool levelComplete = false;
    public int levelNumber = 0;
    public string[] scenes;

    // Start is called before the first frame update
    void Start()
    {
        levelNumber += 1;
    }

    // Update is called once per frame
    void Update()
    {
        print(levelComplete);
        if (levelComplete == true)
        {
            print("Loading Next Scene");
            SceneManager.LoadScene(scenes[levelNumber], LoadSceneMode.Single);
            levelComplete = false;
        }
    }
}
