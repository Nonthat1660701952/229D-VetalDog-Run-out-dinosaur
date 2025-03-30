using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    public GameObject meteorPrefab; // Prefab �ͧ�ء�Һҵ
    public float spawnInterval = 2f; // ���ҷ����㹡�����ҧ�ء�Һҵ���Ф���
    public float spawnRangeX = 10f; // �ͺࢵ����������˹���᡹ X
    public float spawnHeight = 15f; // �����٧����ء�Һҵ�Դ���
    public float spawnRangeZ = 10f; // �ͺࢵ����������˹���᡹ Z

    void Start()
    {
        InvokeRepeating(nameof(SpawnMeteor), 0f, spawnInterval);
    }

    void SpawnMeteor()
    {
        // ��˹����˹�Ẻ����
        Vector3 spawnPosition = new Vector3(
            Random.Range(-spawnRangeX, spawnRangeX),
            spawnHeight,
            Random.Range(-spawnRangeZ, spawnRangeZ)
        );

        // ���ҧ�ء�Һҵ�����˹觷��������
        Instantiate(meteorPrefab, spawnPosition, Quaternion.identity);
    }
}