using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager2 : MonoBehaviour
{
    public static GameManager2 instance;

    int score;
    public TextMeshPro scoretext;

    private void Awake()
    {
        instance = this;
    }
    void Start()
    {
        scoretext.text = score.ToString() +" "+ " Points";
    }

    public void AddScore()
    {
        score += 100;
        scoretext.text = score.ToString() + " " + "Points";
    }
    public void MinusScore()
    {
        score -= 10;
        scoretext.text = score.ToString() + " " + "Points";
    }


}
