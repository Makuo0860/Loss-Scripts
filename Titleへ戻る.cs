using UnityEngine;
using UnityEngine.SceneManagement;

public class Titleへ戻る : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Invoke("Back", 10f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Back()
    {
        SceneManager.LoadScene("Title");
    }
}
