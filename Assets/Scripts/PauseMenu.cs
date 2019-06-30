using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;

    private bool stopped = false;
    private float oldTimeScale;

    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (stopped == false)
            {
                pauseMenu.SetActive(true);
                oldTimeScale = Time.timeScale;
                Time.timeScale = 0;
                stopped = true;
            }
            else if (stopped == true)
            {
                pauseMenu.SetActive(false);
                Time.timeScale = oldTimeScale;
                stopped = false;
            }
        }
    }
}
