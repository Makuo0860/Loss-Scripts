using UnityEngine;
using System.Collections;

public class 上へまいります : MonoBehaviour
{
    public float minTime = 2f;
    public float maxTime = 8f;

    public float moveHeight = 2f;
    public float moveSpeed = 2f;

    private Vector3 startPos;
    private Vector3 upPos;

    void Start()
    {
        startPos = transform.position;
        upPos = startPos + Vector3.up * moveHeight;

        StartCoroutine(MoleRoutine());
    }

    IEnumerator MoleRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(minTime, maxTime));

            yield return StartCoroutine(MoveTo(upPos));

            yield return new WaitForSeconds(3f);

            yield return StartCoroutine(MoveTo(startPos));
        }
    }

    IEnumerator MoveTo(Vector3 target)
    {
        while (Vector3.Distance(transform.position, target) > 0.01f)
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                target,
                moveSpeed * Time.deltaTime
            );

            yield return null;
        }

        transform.position = target;
    }
}