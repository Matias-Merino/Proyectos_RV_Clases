using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcManager : MonoBehaviour
{
    public GameObject uI;
    public GameObject[] npcs;
    public Transform[] spawners;
    float playTimer = 300f;
    float spawnTimer = 5f;

    private void Update()
    {
        playTimer -= Time.deltaTime;
        spawnTimer -= Time.deltaTime;
        if (playTimer >= 0)
        {
            if (spawnTimer <= 0)
            {
                Instantiate(npcs[Random.Range(0, npcs.Length)], spawners[Random.Range(0, spawners.Length)].transform);
                spawnTimer = 5f;
            }
        }
        if (playTimer <= 0)
        {
            uI.SetActive(true);
        }
    }
}
