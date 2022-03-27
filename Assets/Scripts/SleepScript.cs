using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SleepScript : MonoBehaviour
{
    public GameObject textToDisplay;             
    private bool PlayerInZone;

    void Start()
    {

        PlayerInZone = false;                   
        textToDisplay.SetActive(false);
    }


    void Update()
    {
        if (PlayerInZone && Input.GetKeyDown("e"))           //if in zone and press S
        {
            //Sleepy sleepy
            Debug.Log("GGNNNNGGGHH mi mi mi mi mi");
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
            textToDisplay.SetActive(false);
        }
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
