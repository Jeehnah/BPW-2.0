using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayTextBox : MonoBehaviour
{
    public GameObject textBox;

    public Animator animator;

    void OnTriggerEnter (Collider other)
    {
        animator.SetBool("IsOpen", true);

        StartCoroutine(EndDialogue());
    }

    IEnumerator EndDialogue()
    {
        yield return new WaitForSeconds(8);

        animator.SetBool("IsOpen", false);

    }
}
