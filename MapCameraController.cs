using UnityEngine;

public class CameraChange : MonoBehaviour
{

    public GameObject AllCamera;
    public GameObject MiniCamera;

    void Start()
    {

    }

    void Update()
    {
        //ÉJÉÅÉâêÿÇËë÷Ç¶
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (AllCamera.activeSelf)
            {
                AllCamera.gameObject.SetActive(false);
                MiniCamera.gameObject.SetActive(true);
            }
            else
            {
                AllCamera.gameObject.SetActive(true);
                MiniCamera.gameObject.SetActive(false);
            }
        }
    }
}
