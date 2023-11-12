using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Distance : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI distanceText;

    void Update()
    {
        //Debug.Log(player.position.z);
        distanceText.text = player.position.z.ToString("0" + "m");
    }
}
