using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SleepScript : MonoBehaviour
{
    public GameObject textToDisplay;             
    private bool PlayerInZone;
    public GameObject backToBlack;

    void Start()
    {

        PlayerInZone = false;                   
        textToDisplay.SetActive(false);
    }


    void Update()
    {
        if (PlayerInZone && Input.GetKeyDown("e"))           //if in zone and press E
        {
            //Sleepy sleepy
            Debug.Log("GGNNNNGGGHH mi mi mi mi mi");
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
            textToDisplay.SetActive(false);

            StartCoroutine(NextScene());
        }
    }

    IEnumerator NextScene()
    {
        backToBlack.GetComponent<Animator>().Play("BackToBlack");

        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")     //if player in zone
        {
            textToDisplay.SetActive(true);
            PlayerInZone = true;
        }
    }


    private void OnTriggerExit(Collider other)     //if player exit zone
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerInZone = false;
            textToDisplay.SetActive(false);
        }
    }
}
