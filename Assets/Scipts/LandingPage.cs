using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LandingPage : MonoBehaviour
{
    public GameObject landingPage;
    public GameObject mintingUI;
    public GameObject mintButton;
    public GameObject collectionsButton;
   

    public void ClickMe()
    {

        landingPage.SetActive(false);
    }

    public void Minting()
    {
        mintingUI.SetActive(true);
        Invoke("mintComplete", 10);
        mintButton.SetActive(false);
    }

    public void mintComplete()
    {
        mintingUI.SetActive(false);
        collectionsButton.SetActive(true);
    }

    public void LoungeCity()
    {
        SceneManager.LoadScene("Lounge city");

    }

}
