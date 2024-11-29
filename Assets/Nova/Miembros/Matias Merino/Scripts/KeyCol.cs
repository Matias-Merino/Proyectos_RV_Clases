using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCol : MonoBehaviour
{
    public delegate void Keydetect();
    public static event Keydetect open;

    public GameObject llave;
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.CompareTag("Key"))
        {
            Debug.Log("entro la llave");
            open.Invoke();

            Destroy(llave);
        }
    }
}
