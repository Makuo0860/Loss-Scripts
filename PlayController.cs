using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayController : MonoBehaviour
{

    public void OnStartButtonClicked()
    {
        SceneManager.LoadScene("MainGame");
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
