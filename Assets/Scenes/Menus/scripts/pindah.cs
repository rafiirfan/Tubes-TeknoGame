using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class pindah : MonoBehaviour
{
     PlayerScript player;
     Text distanceText;
     private void Awake(){
          player = GameObject.Find("Player").GetComponent<PlayerScript>();
          distanceText = GameObject.Find("DistanceText").GetComponent<Text>();
     }
     public void pay()
     {
          SceneManager.LoadScene("play");
     }
     public void menu()
     {
          SceneManager.LoadScene("menu");
     }
     void Update (){
          int jarak = Mathf.FloorToInt(player.jarak);
          distanceText.text = player.jarak + " m";
     }
}
