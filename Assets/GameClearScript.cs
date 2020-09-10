using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameClearScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Text>().enabled = false;
    }

    // Update is called once per frame
    public void Win()
    {
        gameObject.GetComponent<Text>().enabled = true;
    }
}
