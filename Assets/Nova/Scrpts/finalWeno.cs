using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finalWeno : MonoBehaviour
{
    public GameObject texto1;
  

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            texto1.SetActive(true);
        }
    }
}
