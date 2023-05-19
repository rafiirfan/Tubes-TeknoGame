using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class pindah : MonoBehaviour
{
   public void pay()
   {
        SceneManager.LoadScene("play");
   }
   public void menu()
   {
        SceneManager.LoadScene("menu");
   }
}
