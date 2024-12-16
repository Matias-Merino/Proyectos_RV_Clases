using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcCont2 : MonoBehaviour
{
    float timer = 0;

    private void Update()
    {
        if (timer >= 10)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Fries"))
        {
            GameManager2.instance.AddScore();
            Destroy(gameObject);
        }
        else if (other.gameObject.CompareTag("Burger") || other.gameObject.CompareTag("Soda"))
        {
            GameManager2.instance.MinusScore();
            Destroy(gameObject);
        }
    }
}
