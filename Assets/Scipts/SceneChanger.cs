using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void LoungeCity()
    {
        SceneManager.LoadScene("Lounge city");

    }

    public void PlayerMgt()
    {
        SceneManager.LoadScene("Profile");

    }


    public void RustChallange()
    {
        SceneManager.LoadScene("RustChallange");

    }
}
