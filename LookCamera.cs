using UnityEngine;
using UnityEngine.SceneManagement;

public class LookCamera : MonoBehaviour
{
    public Transform target;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
        Invoke("clear", 20f);
    }

    void clear()
    {
        SceneManager.LoadScene("GameWin");
    }
}
