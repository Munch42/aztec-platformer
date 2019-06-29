using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public bool levelComplete = false;
    public int levelNumber = 0;
    public float waitTime = 4f;
    public string[] scenes;

    // Start is called before the first frame update
    void Start()
    {
        levelNumber += 1;
    }

    IEnumerator changeScene()
    {
        yield return new WaitForSeconds(waitTime);
        SceneManager.LoadScene(scenes[levelNumber], LoadSceneMode.Single);
        levelComplete = false;
    }

    // Update is called once per frame
    void Update()
    {
        print(levelComplete);
        if (levelComplete == true)
        {
            print("Loading Next Scene");
            StartCoroutine("changeScene");
        }
    }

    public void startGame()
    {
        waitTime = 0f;
        levelNumber = 0;
        levelComplete = true;
    }

    public void selectLevel(int selectedLevelNum)
    {
        levelNumber = selectedLevelNum;
        waitTime = 0f;
        levelComplete = true;
    }
}
