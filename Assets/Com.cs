using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float forwardSpeed = 5f;     // ����������觢�ҧ˹��
    public float strafeSpeed = 3f;      // �������Ǣ�Ѻ���¢��
    public float rotationSpeed = 10f;   // ��������㹡����ع

    private void Update()
    {
        // �Թ仢�ҧ˹��
        Vector3 moveDirection = Vector3.forward * forwardSpeed;

        // �Ѻ Input ����-���
        float horizontalInput = Input.GetAxis("Horizontal");
        moveDirection += Vector3.right * horizontalInput * strafeSpeed;

        // ����͹���
        transform.Translate(moveDirection * Time.deltaTime, Space.World);

        // ��ع��ǵ����ȷҧ
        if (horizontalInput != 0)
        {
            Quaternion targetRotation = Quaternion.LookRotation(new Vector3(horizontalInput, 0, 1f));
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
    }
}