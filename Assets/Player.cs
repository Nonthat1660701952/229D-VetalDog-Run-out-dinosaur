using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    public Vector3 respawnPoint; // ���˹�������鹢ͧ����Ф�
    public GameObject explosionEffect; // �Ϳ࿡��͹��� (�����)
    public string hazardTag = "Hazard"; // Tag �ͧ��觷�������� �� "Hazard", "Meteor"

    void Start()
    {
        respawnPoint = transform.position; // �ѹ�֡�ش�Դ�������
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(hazardTag)) // ��Ҫ��Ѻ����ѹ����
        {
            Die();
        }
    }

    void Die()
    {
        if (explosionEffect != null)
        {
            Instantiate(explosionEffect, transform.position, Quaternion.identity); // ���ҧ�Ϳ࿡�����Դ
        }

        gameObject.SetActive(false); // �Դ����Фê��Ǥ���
        Invoke(nameof(Respawn), 2f); // �� 2 �� �����Դ����

    }

    void Respawn()
    {
        transform.position = respawnPoint; // ��Ѻ仨ش�������
        gameObject.SetActive(true); // �Դ����Ф�����

    }
    
}