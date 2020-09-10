using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{
    public GameObject gameClear;
    int speed = 5;
    public int blockCt = 20;
    Rigidbody rb;
    Vector3 V;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce((transform.up + transform.right) * speed, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void Update()
    {
        if (blockCt == 0)
        {
            GetComponent<Rigidbody>().velocity = Vector3.zero;
            gameClear.SendMessage("Win");
            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene("title");
            }
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Block")
        {
            blockCt -= 1;
        }
    }
}
