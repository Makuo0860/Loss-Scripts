using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class 逃げるプレイヤー : MonoBehaviour
{
    private float speed;
    private float rotatespeed;
    public Transform target;
    public 下から出てくる添田 soeda1;
    public 左から出てくる添田 soeda2;
    public 右から出てくる添田 soeda3;

    void Start()
    {
        speed = 0.1f;
        rotatespeed = 0;
    }

    void Update()
    {
        if (this.transform.position.z >= -85)
        {
            speed = 0;
            rotatespeed = 1f;
        }
        if (this.transform.eulerAngles.y >= 180)
        {
            rotatespeed = 0;
        }
        this.transform.Translate(0, 0, speed);
        this.transform.Rotate(0, rotatespeed, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Invoke("Restart", 15);
            Invoke("Late", 5);
            soeda1.StartMove();
            soeda2.StartMove();
            soeda3.StartMove();
        }
    }

    void Restart()
    {
        SceneManager.LoadScene("GameOver 1");
    }

    void Late()
    {
        transform.LookAt(target);
    }
}