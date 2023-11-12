using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

namespace Wave
{
    public class GroundSpawner : MonoBehaviour
    {
        GroundTile groundtile;

        [SerializeField] private int tileStartCount = 5;

        [SerializeField] GameObject groundTile;
        Vector3 nextSpawnPoint;

        //private List<GameObject> Obstacles = new List<GameObject>();

        public void SpawnTile(/*bool DelayObstacles*/)
        {
            GameObject temp = Instantiate(groundTile, nextSpawnPoint, Quaternion.identity);
            nextSpawnPoint = temp.transform.GetChild(1).transform.position;

            /*if (DelayObstacles)
            {
                temp.GetComponent<GroundTile>().SpawnObstacle();
            }*/
        }

        // Start is called before the first frame update
        void Start()
        {

            //To give random unique number lel
            //Random.InitState(System.DateTime.Now.Millisecond);

            #region Handles amount of platform to spawn
            for (int i = 0; i < tileStartCount; i++)
            {
                /*if (i < 2) 
                    SpawnTile(false);
                else
                    SpawnTile(true);*/

                SpawnTile();
            }
            #endregion
        }
    }
}
