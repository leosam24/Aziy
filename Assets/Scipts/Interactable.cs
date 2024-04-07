using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public GameObject InteractUI;
    public GameObject ChallangeUI;

    private void OnTriggerEnter(Collider other)
    {
        // Check if the collider belongs to the GameObject we're interested in
        if (other.gameObject.CompareTag("Player")) // Change "Player" to your desired tag
        {
            // Show the UI element
            InteractUI.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Check if the collider belongs to the GameObject we're interested in
        if (other.gameObject.CompareTag("Player")) // Change "Player" to your desired tag
        {
            // Hide the UI element
            InteractUI.SetActive(false);
            ChallangeUI.SetActive(false);
        }
    }


    public void challangeOn ()
    {
        ChallangeUI.SetActive(true);
        InteractUI.SetActive(false);
    }

    public void challangeOff()
    {
        ChallangeUI.SetActive(false);
        InteractUI.SetActive(true);
    }
}
