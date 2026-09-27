using UnityEngine;

public class 下から出てくる添田 : MonoBehaviour
{
    private float speed;
    public bool startMove = false;
    public AudioClip sound;

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
        if (this.transform.position.y > 1.5)
        {
            speed = 0;
            Invoke("Second", 3f);
        }
        this.transform.Translate(0, speed, 0);
    }
    public void Second()
    {
        AudioSource.PlayClipAtPoint(sound, this.transform.position);
    }
}