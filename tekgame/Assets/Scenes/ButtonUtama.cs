using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonUtama : MonoBehaviour
{
        public void MenuScene(string layarMenu)
    {
        SceneManager.LoadScene(layarMenu);
    }
    
    public void playScene(string play)
    {
        SceneManager.LoadScene(play);
    }

}
