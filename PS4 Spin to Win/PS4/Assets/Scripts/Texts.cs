﻿
using UnityEngine;
using UnityEngine.UI;
public class Texts : MonoBehaviour
{
    public Transform player;
    public Text score;

    // Update is called once per frame
    void Update()
    {
        score.text = player.position.z.ToString("0");  
    }
}
