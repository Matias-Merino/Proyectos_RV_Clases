using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key_anim : MonoBehaviour
{
    // Start is called before the first frame update
    public void StopAnim()
    {
        GetComponent<Animator>().enabled = false;
    }
}
