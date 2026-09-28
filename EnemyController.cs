using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform target;

    public float findDistance = 100f;   // 発見距離
    public float loseDistance = 150f;   // 見失う距離
    public Transform[] goals; //巡回先ゴール数（Unityからゴール数は指定）
    private int destNum = 0;

    private bool isChasing = false;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.destination = goals[destNum].position;
    }

    void nextGoal()
    {
        destNum = Random.Range(0, 10);//右の数字にゴール数を設定
        agent.destination = goals[destNum].position;
    }

    void Update()
    {
        float dist = Vector3.Distance(transform.position, target.position);

        if (!isChasing)
        {
            //ゴールに近づいたら次のゴールへ行く
            if(agent.remainingDistance < 0.5f)
            {
                nextGoal();
            }
            if (dist <= findDistance)
            {
                isChasing = true;
            }
        }

        if (isChasing)
        {
            agent.SetDestination(target.position);

            if (dist >= loseDistance)
            {
                isChasing = false;
                agent.ResetPath();
            }
        }
    }
}