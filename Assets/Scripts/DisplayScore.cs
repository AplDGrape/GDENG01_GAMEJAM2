using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayScore : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoreText;

    Distance distance;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = player.position.z.ToString("Score: " + "0" + "m");
    }
}
