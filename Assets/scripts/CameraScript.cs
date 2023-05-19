using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public SpriteRenderer sprite;
    // Start is called before the first frame update
    void Start()
    {
        float screenRatio = (float) Screen.width / (float) Screen.height;
        float targetRatio = sprite.bounds.size.x / sprite.bounds.size.y;

        if (screenRatio >= targetRatio)
        {
            Camera.main.orthographicSize = sprite.bounds.size.y / 2;
        }else
        {
            {
                float diffRatio = targetRatio / screenRatio;
                Camera.main.orthographicSize = sprite.bounds.size.y / 2 * diffRatio;
            }
        }
    }
}
