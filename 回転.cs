using UnityEngine;

public class 回転 : MonoBehaviour
{
    public float speed = 90f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0,speed * Time.deltaTime,0);
    }
}
