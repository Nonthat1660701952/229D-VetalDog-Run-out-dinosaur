using UnityEngine;
using System.Collections;

public class MeteorSpawner : MonoBehaviour
{
    public GameObject meteorPrefab; // Prefab �ͧ�ء�Һҵ
    public float spawnRangeX = 10f; // �ͺࢵ����������˹�᡹ X
    public float spawnRangeZ = 10f; // �ͺࢵ����������˹�᡹ Z
    public float spawnHeight = 15f; // �����٧����ء�Һҵ�Դ���

    public float minSpawnTime = 1f; // ������������ش����ء�Һҵ���Դ
    public float maxSpawnTime = 4f; // ���������٧�ش����ء�Һҵ���Դ

    void Start()
    {
        StartCoroutine(SpawnMeteorRoutine());
    }

    IEnumerator SpawnMeteorRoutine()
    {
        while (true)
        {
            float waitTime = Random.Range(minSpawnTime, maxSpawnTime);
            yield return new WaitForSeconds(waitTime); // �����ҡ�͹���ҧ����

            Vector3 spawnPosition = new Vector3(
                Random.Range(-spawnRangeX, spawnRangeX),
                spawnHeight,
                Random.Range(-spawnRangeZ, spawnRangeZ)
            );

            Instantiate(meteorPrefab, spawnPosition, Quaternion.identity);
        }
    }
}