using UnityEngine;

public class FPHeadBob : MonoBehaviour
{
    public Rigidbody playerRb;

    public float amplitude = 0.03f;
    public float frequency = 10f;

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.localPosition;
    }

    void Update()
    {
        if (playerRb == null) return;

        Vector3 horizontalVelocity =
            new Vector3(playerRb.linearVelocity.x, 0, playerRb.linearVelocity.z);

        float speed = horizontalVelocity.magnitude;

        if (speed > 0.1f)
        {
            Vector3 pos = startPos;

            pos.x += Mathf.Sin(Time.time * frequency) * amplitude;
            pos.y += Mathf.Cos(Time.time * frequency * 2f) * amplitude;

            transform.localPosition = pos;
        }
        else
        {
            transform.localPosition =
                Vector3.Lerp(
                    transform.localPosition,
                    startPos,
                    Time.deltaTime * 8f);
        }
    }
}