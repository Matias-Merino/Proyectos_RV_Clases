using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("NPC") || other.gameObject.CompareTag("Floor"))
        {
            GameManager2.instance.MinusScore();
            Destroy(gameObject);
        }
    }
}
