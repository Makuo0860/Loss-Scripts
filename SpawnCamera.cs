using UnityEngine;

public class SpawnCamera : MonoBehaviour
{
    public GameObject clearCamera1;
    public GameObject clearCamera2;
    public GameObject clearCamera3;
    public GameObject clearCamera4;
    private bool started = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        clearCamera1.SetActive(false);
        clearCamera2.SetActive(false);
        clearCamera3.SetActive(false);
        clearCamera4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (started) return;
        GameObject[] items = GameObject.FindGameObjectsWithTag("Item");
        if(items.Length == 0)
        {
            started = true;
            clearCamera1.SetActive(true);
            Invoke("Stop1", 1f);
        }
    }

    void Stop1()
    {
        clearCamera1.SetActive(false);
        clearCamera2.SetActive(true);
        Invoke("Stop2", 2f);
    }

    void Stop2()
    {
        clearCamera2.SetActive(false);
        clearCamera3.SetActive(true);
        Invoke("Stop3", 2f);
    }

    void Stop3()
    {
        clearCamera3.SetActive(false);
        clearCamera4.SetActive(true);
        Invoke("Stop4", 5f);
    }

    void Stop4()
    {
        clearCamera4.SetActive(false);
    }
}
