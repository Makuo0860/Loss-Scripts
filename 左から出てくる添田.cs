using UnityEngine;

public class 左から出てくる添田 : MonoBehaviour
{
    private float speed;
    public bool startMove = false;

    void Start()
    {
        speed = 0.01f;
    }

    public void StartMove()
    {
        Invoke("EnableMove", 3f);
    }

    void EnableMove()
    {
        startMove = true;

    }

    void Update()
    {
        if (!startMove) return;
        if (this.transform.position.x < 60.7)
        {
            speed = 0;
        }
        this.transform.Translate(speed,0, 0);
    }
}