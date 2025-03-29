using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f; // ความเร็วในการวิ่ง

    void Update()
    {
        // เดินไปข้างหน้าอัตโนมัติ
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        // หรือจะเปลี่ยนเป็นกด W ถึงจะวิ่ง
        /*
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        */
    }
}