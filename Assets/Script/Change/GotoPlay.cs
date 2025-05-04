using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GotoPlay : MonoBehaviour
{
    public Button Gamein;

    void Start()
    {
        Gamein.onClick.AddListener(Gotogame);
    }

    void Gotogame()
    {
        SceneManager.LoadScene("project"); // ชื่อ Scene ต้องตรงกับใน Build Settings
    }
}
