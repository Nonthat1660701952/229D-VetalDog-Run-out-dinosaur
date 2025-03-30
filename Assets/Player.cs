using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    public Vector3 respawnPoint; // ตำแหน่งเริ่มต้นของตัวละคร
    public GameObject explosionEffect; // เอฟเฟกต์ตอนตาย (ถ้ามี)
    public string hazardTag = "Hazard"; // Tag ของสิ่งที่ทำให้ตาย เช่น "Hazard", "Meteor"

    void Start()
    {
        respawnPoint = transform.position; // บันทึกจุดเกิดเริ่มต้น
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(hazardTag)) // ถ้าชนกับสิ่งอันตราย
        {
            Die();
        }
    }

    void Die()
    {
        if (explosionEffect != null)
        {
            Instantiate(explosionEffect, transform.position, Quaternion.identity); // สร้างเอฟเฟกต์ระเบิด
        }

        gameObject.SetActive(false); // ปิดตัวละครชั่วคราว
        Invoke(nameof(Respawn), 2f); // รอ 2 วิ แล้วเกิดใหม่

    }

    void Respawn()
    {
        transform.position = respawnPoint; // กลับไปจุดเริ่มต้น
        gameObject.SetActive(true); // เปิดตัวละครใหม่

    }
    
}