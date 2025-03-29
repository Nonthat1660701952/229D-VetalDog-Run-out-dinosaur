using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float forwardSpeed = 5f;     // ความเร็ววิ่งข้างหน้า
    public float strafeSpeed = 3f;      // ความเร็วขยับซ้ายขวา
    public float rotationSpeed = 10f;   // ความเร็วในการหมุน

    private void Update()
    {
        // เดินไปข้างหน้า
        Vector3 moveDirection = Vector3.forward * forwardSpeed;

        // รับ Input ซ้าย-ขวา
        float horizontalInput = Input.GetAxis("Horizontal");
        moveDirection += Vector3.right * horizontalInput * strafeSpeed;

        // เคลื่อนที่
        transform.Translate(moveDirection * Time.deltaTime, Space.World);

        // หมุนตัวตามทิศทาง
        if (horizontalInput != 0)
        {
            Quaternion targetRotation = Quaternion.LookRotation(new Vector3(horizontalInput, 0, 1f));
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        }
    }
}