using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public kontroldino dinokontrol;
    public GameObject prefabcactus;
    public List<Sprite> listSpriteCactus;
    public float timeSpawn = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (dinokontrol.startGame == true)
        {
        timeSpawn -= Time.deltaTime;
        if (timeSpawn <-0)
        {
            GameObject newCactus = Instantiate(prefabcactus, transform.position, transform.rotation);
            newCactus.GetComponent<SpriteRenderer>().sprite = listSpriteCactus [Random.Range(0,listSpriteCactus.Count)];
            timeSpawn = Random.Range(0.4f,3.0f);
        }
        }
    }
}
