using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // ��������㹡�����

    void Update()
    {
        // �Թ仢�ҧ˹���ѵ��ѵ�
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        // ���ͨ�����¹�繡� W �֧�����
        /*
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        */
    }
}