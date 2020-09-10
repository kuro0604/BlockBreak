using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BottomController : MonoBehaviour
{
    public GameObject gameOver;
    bool goTitle = false;
    
    // Update is called once per frame
    void Update()
    {
        if (goTitle)
        {
            if(Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene("title");
            }
        }
    }
    private void OnCollisionEnter(Collision col)
    {
        Destroy(col.gameObject);
        gameOver.SendMessage("Lose");
            goTitle = true;
    }
}
