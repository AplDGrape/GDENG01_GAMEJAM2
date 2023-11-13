using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

namespace Wave
{
    public class GroundTile : MonoBehaviour
    {
        GroundSpawner groundSpawner;

        [SerializeField] List<GameObject> obstacles;
        private List<GameObject> currentObstacles;

        // Start is called before the first frame update
        void Start()
        {
            currentObstacles = new List<GameObject>();

            groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();
            SpawnObstacle();
        }

        void OnTriggerExit(Collider other)
        {
            groundSpawner.SpawnTile(/*true*/);
            Destroy(gameObject, 1);
        }

        public void SpawnObstacle()
        {
            int obstacleSpawnIndex = Random.Range(2, 5);
            Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;

            //Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            GameObject obstaclePrefab = SelectRandomGameObjectFromList(obstacles);
            GameObject obstacle = Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
            currentObstacles.Add(obstacle);

        }

        private GameObject SelectRandomGameObjectFromList(List<GameObject> list)
        {
            if (list.Count == 0) return null;
            return list[Random.Range(0, list.Count)];
        }
    }
}