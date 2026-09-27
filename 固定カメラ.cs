using UnityEngine;

public class 固定カメラ : MonoBehaviour
{
    public Transform player;
    public float height = 20f;

    void LateUpdate()
    {
        if (transform.position.z <= 26 && transform.position.z >= -101 && transform.position.x >= -33 && transform.position.x <= 101)
        {
            transform.position = player.position + Vector3.up * height;

            transform.rotation = Quaternion.Euler(90f, 90f, 0f);
        }
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
