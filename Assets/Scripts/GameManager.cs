using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown("q"))
        {
            Application.Quit();
        }

        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene(0);
        }
    }
}
