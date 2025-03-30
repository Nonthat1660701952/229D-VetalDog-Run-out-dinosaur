using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void LoadScene(string SampleScene)
    {
        SceneManager.LoadScene(SampleScene); // โหลดซีนตามชื่อที่กำหนด
    }
}