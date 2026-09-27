using UnityEngine;

public class SpawnClearItem : MonoBehaviour
{
    public GameObject clearItem;
    public float speed;

    void Start()
    {
        speed = 0.5f;
        clearItem.SetActive(false);
    }

    void Update()
    {
        GameObject[] items = GameObject.FindGameObjectsWithTag("Item");

        if (items.Length == 0)
        {
            clearItem.SetActive(true);
            Pauser.Pause();
            //x•bŒã‚ÉÄŠJ‚³‚¹‚é
            Invoke(nameof(ResumeGame), 5f);
            if (transform.position.y > 1.3f)
            {
                speed = 0;
            }
            this.transform.Translate(0, speed * Time.deltaTime, 0);
        }
    }

    void ResumeGame()
    {
        Pauser.Resume();
    }
}