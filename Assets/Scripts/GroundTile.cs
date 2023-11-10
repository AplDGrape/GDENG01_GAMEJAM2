using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Wave
{
    public class GroundTile : MonoBehaviour
    {
        GroundSpawner groundSpawner;

        // Start is called before the first frame update
        void Start()
        {
            groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();
        }

        void OnTriggerExit(Collider other)
        {
            groundSpawner.SpawnTile();
            Destroy(gameObject, 3);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}