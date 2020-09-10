using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;   // 追加
public class SceneLoad : MonoBehaviour
{
    public void LoadMain()
    {
        SceneManager.LoadScene("GameScene");   // 変更
    }
}