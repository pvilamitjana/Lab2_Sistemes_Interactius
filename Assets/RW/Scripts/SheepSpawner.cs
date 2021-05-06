using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepSpawner : MonoBehaviour
{

    public bool canSpawn = true;
    public GameObject sheepPrefab;
    public List<Transform> sheepSpawnPositions = new List<Transform>();
    public float timeBetweenSpawns;
    private List<GameObject> sheepList = new List<GameObject>();

 

    // Start is called before the first frame update
    void Start()
    {
        Vector3 hi = new Vector3(1,1,15);
        GameObject sheep = Instantiate(sheepPrefab, new Vector3(1, 1, 15), Quaternion.identity);
        //sheepList.Add(sheep);

    }

    // Update is called once per frame
   void Update()
    {
        StartCoroutine (SpawnRoutine());
    }

    private void SpawnSheep()
    {
        Vector3 randomPosition = sheepSpawnPositions[Random.Range(0,sheepSpawnPositions.Count)].position;
        GameObject sheep = Instantiate(sheepPrefab, randomPosition,sheepPrefab.transform.rotation);
        sheepList.Add(sheep);
        sheep.GetComponent<Sheep>().SetSpawner(this);
    }

   private IEnumerator SpawnRoutine()
   {
       while(canSpawn)
       {
           SpawnSheep();
           yield return new WaitForSeconds(timeBetweenSpawns);
       }
   }

   public void RemoveSheepFromList(GameObject sheep)
   {
       sheepList.Remove(sheep);
   }
}
