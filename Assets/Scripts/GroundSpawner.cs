using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

namespace Wave
{
    public class GroundSpawner : MonoBehaviour
    {
        [SerializeField] private int tileStartCount = 5;
        //[SerializeField] private int minStraightTiles = 3;
        //[SerializeField] private int maxStraightTiles = 10;

        [SerializeField] private GameObject startingTile;
        [SerializeField] List<GameObject> obstacles;

        private Vector3 currentTileLocation = Vector3.zero;
        private Vector3 currentTileDirection = Vector3.forward;
        private GameObject prevTile;

        private List<GameObject> currentTiles;
        private List<GameObject> currentObstacles;

        public GameObject groundTile;
        Vector3 nextSpawnPoint;

        // Start is called before the first frame update
        void Start()
        {
            currentTiles = new List<GameObject>();
            currentObstacles = new List<GameObject>();

            //To give random unique number lel
            Random.InitState(System.DateTime.Now.Millisecond);

            #region Handles amount of platform to spawn
            for (int i = 0; i < tileStartCount; i++)
            {
                SpawnTile(/*startingTile.GetComponent<Tile>(), false*/);
            }
            #endregion
        }

        public void SpawnTile(/*Tile tile, bool spawnObstacle*/)
        {
            //prevTile = GameObject.Instantiate(tile.gameObject, currentTileLocation, Quaternion.identity);
            //currentTiles.Add(prevTile);
            GameObject temp = Instantiate(groundTile, nextSpawnPoint, Quaternion.identity);
            //currentTileLocation += Vector3.Scale(prevTile.GetComponent<Renderer>().bounds.size, currentTileDirection);
            nextSpawnPoint = temp.transform.GetChild(1).transform.position;

            //if (SpawnObstacle) SpawnObstacle();
        }

        //private void SpawnObstacle()
        //{
        //    if (Random.value > 0.2f) return;

        //    GameObject obstaclePrefab = SelectRandomGameObjectFromList(obstacles);
        //    GameObject obstacle = Instantiate(obstaclePrefab, currentTileLocation, Quaternion.identity);
        //    currentObstacles.Add(obstacle);
        //}

        //private GameObject SelectRandomGameObjectFromList(List<GameObject> list)
        //{
        //    if (list.Count == 0) return null;
        //    return list[SelectRandomGameObjectFromList().Range(0, list.Count)];
        //}
    }
}
