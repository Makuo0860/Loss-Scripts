using UnityEngine;
using UnityEngine.SceneManagement;

public class FPSController : MonoBehaviour
{
    private Rigidbody rb;
    private Vector3 angle;
    private Vector3 input;

    private float moveSpeed = 10f;
    private float cameraSpeed = 10f;
    private GameObject Player;
    private float speed;
    private float sensitivity = 5.0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        rb = GetComponent<Rigidbody>();
        
        angle = input = Vector3.zero;
    }

    void Update()
    {
        // キーを離したら停止
        if (Input.GetKeyUp(KeyCode.W) ||
            Input.GetKeyUp(KeyCode.S) ||
            Input.GetKeyUp(KeyCode.D) ||
            Input.GetKeyUp(KeyCode.A))
        {
            rb.linearVelocity = Vector3.zero;
        }

        angle += new Vector3(-Input.GetAxis("Mouse Y"),Input.GetAxis("Mouse X"),0) * sensitivity;
        angle = new Vector3(Mathf.Clamp(angle.x, -85f, 85f), angle.y);

        transform.eulerAngles = new Vector3(angle.x, angle.y, 0);
    }

    void FixedUpdate()
    {
        float z = 0;
        float x = 0;

        // 前
        if (Input.GetKey(KeyCode.W))
        {
            z = 1;
        }
        //後ろ
        if (Input.GetKey(KeyCode.S))
        {
            z = -1;
        }

        // 左
        if (Input.GetKey(KeyCode.D))
        {
            x = 1;
        }
        //左
        if (Input.GetKey(KeyCode.A))
        {
            x = -1;
        }

        // 移動方向
        Vector3 move =
            transform.forward * z +
            transform.right * x;

        // 斜め移動速度を統一
        move = move.normalized * moveSpeed;

        // 移動
        rb.linearVelocity = new Vector3(
            move.x,
            rb.linearVelocity.y,
            move.z
        );
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
        }
    }
}