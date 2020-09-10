using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Text>().enabled = false;
    }

    // Update is called once per frame
    void Lose()
    {
        gameObject.GetComponent<Text>().enabled = true;
    }
}
