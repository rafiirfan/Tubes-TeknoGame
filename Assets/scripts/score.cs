using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour
{
    private float waktuMulai;
    Text distanceText;
    private void Awake(){
        distanceText = GameObject.Find("DistanceText").GetComponent<Text>();
    }
    // Start is called before the first frame update
    void Start()
    {
        waktuMulai = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float jarak = Time.time - waktuMulai;
        distanceText.text = jarak.ToString("F0") + " m";
    }
}
