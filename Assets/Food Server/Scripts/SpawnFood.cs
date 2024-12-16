using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFood : MonoBehaviour
{
    public Transform spawnPoint;
    public GameObject food;


    public void FoodSpawn()
    {
        Instantiate(food, spawnPoint);
    }

}
