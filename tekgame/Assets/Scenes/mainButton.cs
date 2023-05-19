using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainButton : MonoBehaviour
{
    public void playScene(string play)
    {
        SceneManager.LoadScene("play");
    }
}
