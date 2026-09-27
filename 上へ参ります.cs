using UnityEngine;
using System.Collections;

public class 上へまいります : MonoBehaviour
{
    public float minTime = 2f;      // 最小待機時間
    public float maxTime = 8f;      // 最大待機時間

    public float moveHeight = 2f;   // 出てくる高さ
    public float moveSpeed = 2f;    // 上下する速さ

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
            // ランダム時間待機
            yield return new WaitForSeconds(Random.Range(minTime, maxTime));

            // 上昇
            yield return StartCoroutine(MoveTo(upPos));

            // 3秒停止
            yield return new WaitForSeconds(3f);

            // 下降
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