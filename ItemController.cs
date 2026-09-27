using UnityEngine;

public class Item : MonoBehaviour
{
    public int point = 10;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            FindObjectOfType<Score>().AddScore(point);

            this.gameObject.SetActive(false);
        }
    }
}