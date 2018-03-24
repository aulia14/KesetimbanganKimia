using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallonSpawnPoints : MonoBehaviour {
    public GameObject[] objectSpawn;
    public Transform[] spawnPoints;

    public float delays;


    void Start()
    {
        SpawnAwal();
        StartCoroutine(SpawnObject());
        StartCoroutine(SpawnObject2());
        StartCoroutine(SpawnObject3());
    }
    void SpawnAwal(){
        Transform spawnPoint = spawnPoints[0];
        GameObject spawnObject = Instantiate(objectSpawn[0], spawnPoint.position, spawnPoint.rotation);
        Destroy(spawnObject, 5f);
        Transform spawnPoint1 = spawnPoints[1];
        GameObject spawnObject1 = Instantiate(objectSpawn[1], spawnPoint1.position, spawnPoint1.rotation);
        Destroy(spawnObject1, 5f);
        Transform spawnPoint2 = spawnPoints[2];
        GameObject spawnObject2 = Instantiate(objectSpawn[2], spawnPoint2.position, spawnPoint2.rotation);
        Destroy(spawnObject2, 60f);
    }
    IEnumerator SpawnObject()
    {
        while (true)
        {
            float delay = delays ;
            yield return new WaitForSeconds(delay);

            //int spawnIndex = Random.Range(0, spawnPoints.Length);
            Transform spawnPoint = spawnPoints[0];
            GameObject spawnObject = Instantiate(objectSpawn[0], spawnPoint.position, spawnPoint.rotation);
            Destroy(spawnObject, 5f);
        }
    }
    IEnumerator SpawnObject2()
    {
        while (true)
        {
             float delay = delays ;
            yield return new WaitForSeconds(delay);

           // int spawnIndex = Random.Range(0, spawnPoints.Length);
            Transform spawnPoint = spawnPoints[1];
            GameObject spawnObject = Instantiate(objectSpawn[1], spawnPoint.position, spawnPoint.rotation);

            Destroy(spawnObject, 60f);
        }
    }
    IEnumerator SpawnObject3()
    {
        while (true)
        {
            float delay = delays ;
            yield return new WaitForSeconds(delay); 
           // int spawnIndex = Random.Range(0, spawnPoints.Length);
            Transform spawnPoint = spawnPoints[2];
            GameObject spawnObject = Instantiate(objectSpawn[2], spawnPoint.position, spawnPoint.rotation);

            Destroy(spawnObject, 60f);
        }
    }
}
