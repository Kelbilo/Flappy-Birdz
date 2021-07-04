using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boms : MonoBehaviour
{
    public float speed = 1f;

    public void Update()
    {
        UpSpeed();
        transform.position += Vector3.left * speed * Time.deltaTime;
    }

    void UpSpeed()
    {
        if (GameManager.score > 0 && GameManager.score < 20)
        {
            speed = 2f;
        }
        else if (GameManager.score > 20 && GameManager.score < 40)
        {
            speed = 2.5f;
        }
        else if (GameManager.score > 40 && GameManager.score < 100)
        {
            speed = 3f;
        }
        else if (GameManager.score > 100)
        {
            speed = 3.5f;
        }
    }
}
