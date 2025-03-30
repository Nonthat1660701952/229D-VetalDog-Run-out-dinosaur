using UnityEngine;
using System.Collections;

public class MeteorSpawner : MonoBehaviour
{
    public GameObject meteorPrefab; // Prefab ของอุกกาบาต
    public float spawnRangeX = 10f; // ขอบเขตการสุ่มตำแหน่งแกน X
    public float spawnRangeZ = 10f; // ขอบเขตการสุ่มตำแหน่งแกน Z
    public float spawnHeight = 15f; // ความสูงที่อุกกาบาตเกิดขึ้น

    public float minSpawnTime = 1f; // เวลาสุ่มต่ำสุดที่อุกกาบาตจะเกิด
    public float maxSpawnTime = 4f; // เวลาสุ่มสูงสุดที่อุกกาบาตจะเกิด

    void Start()
    {
        StartCoroutine(SpawnMeteorRoutine());
    }

    IEnumerator SpawnMeteorRoutine()
    {
        while (true)
        {
            float waitTime = Random.Range(minSpawnTime, maxSpawnTime);
            yield return new WaitForSeconds(waitTime); // รอเวลาก่อนสร้างใหม่

            Vector3 spawnPosition = new Vector3(
                Random.Range(-spawnRangeX, spawnRangeX),
                spawnHeight,
                Random.Range(-spawnRangeZ, spawnRangeZ)
            );

            Instantiate(meteorPrefab, spawnPosition, Quaternion.identity);
        }
    }
}