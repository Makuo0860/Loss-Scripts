using UnityEngine;
using UnityEngine.UI;

public class ItemCanvas : MonoBehaviour
{
    public Text ScoreLabel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int count = GameObject.FindGameObjectsWithTag("Item").Length;
        ScoreLabel.text = count.ToString();
    }
}
