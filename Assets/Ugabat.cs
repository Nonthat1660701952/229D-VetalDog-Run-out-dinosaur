using UnityEngine;

public class MeteorSpawner : MonoBehaviour
{
    public GameObject meteorPrefab; // Prefab ของอุกกาบาต
    public float spawnInterval = 2f; // เวลาที่ใช้ในการสร้างอุกกาบาตแต่ละครั้ง
    public float spawnRangeX = 10f; // ขอบเขตการสุ่มตำแหน่งแนวแกน X
    public float spawnHeight = 15f; // ความสูงที่อุกกาบาตเกิดขึ้น
    public float spawnRangeZ = 10f; // ขอบเขตการสุ่มตำแหน่งแนวแกน Z

    void Start()
    {
        InvokeRepeating(nameof(SpawnMeteor), 0f, spawnInterval);
    }

    void SpawnMeteor()
    {
        // กำหนดตำแหน่งแบบสุ่ม
        Vector3 spawnPosition = new Vector3(
            Random.Range(-spawnRangeX, spawnRangeX),
            spawnHeight,
            Random.Range(-spawnRangeZ, spawnRangeZ)
        );

        // สร้างอุกกาบาตที่ตำแหน่งที่สุ่มได้
        Instantiate(meteorPrefab, spawnPosition, Quaternion.identity);
    }
}