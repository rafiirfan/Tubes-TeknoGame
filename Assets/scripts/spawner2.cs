using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner2 : MonoBehaviour
{
    public GameLogic GameLogic;
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
        if (!GameLogic.isGamePaused)
        {
        timeSpawn -= Time.deltaTime;
        if (timeSpawn <-0)
        {
            GameObject newCactus = Instantiate(prefabcactus, transform.position, transform.rotation);
            newCactus.GetComponent<SpriteRenderer>().sprite = listSpriteCactus [Random.Range(0,listSpriteCactus.Count)];
            timeSpawn = Random.Range(1.0f,3.0f);
        }
        }
    }
}
