using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
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
            SpawnObstacle();
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

        public GameObject obstaclePrefab;

        void SpawnObstacle()
        {
            int obstacleSpawnIndex = Random.Range(2, 5);
            Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;

            Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);

        }
    }
}