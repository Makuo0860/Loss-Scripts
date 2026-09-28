using UnityEngine;

public class RespawnItem : MonoBehaviour
{
    public GameObject item;

    //必要なスコア
    private int nextRespawnScore = 100;

    void Update()
    {
        if (!item.activeSelf &&
            Score.score >= nextRespawnScore)
        {
            item.SetActive(true);
            //次に復活するためのスコア
            nextRespawnScore += 100;

            Debug.Log("復活");
        }
    }
}
