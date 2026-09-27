using UnityEngine;

public class 揺れ : MonoBehaviour
{
    public float strength = 0.05f;

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.localPosition;
    }

    void Update()
    {
        transform.localPosition = startPos + Random.insideUnitSphere * strength;
    }
}