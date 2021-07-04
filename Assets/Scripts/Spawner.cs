using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject pipe;
    public float maxTime = 1f;
    private float timer = 0f;
    public float height;

    void Start()
    {
        GameObject newPipe = Instantiate(pipe);
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }

    void Update()
    {
        DownMaxTime();
        if (timer > maxTime)
        {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newPipe, 10);
            timer = 0f;
        }
        timer += Time.deltaTime;
    }

    void DownMaxTime()
    {
        if (GameManager.score > 0 && GameManager.score < 20)
        {
            maxTime = 2.0f;
        }
        else if (GameManager.score > 20 && GameManager.score < 40)
        {
            maxTime = 1.5f;
        }
        else if (GameManager.score > 40 && GameManager.score < 100)
        {
            maxTime = 1.0f;
        }
        else if (GameManager.score > 100)
        {
            maxTime = 0.8f;
        }
    }
}