using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    // publicにしてInspectorから設定できるようにする
    public Text gameOverMessage;

    void OnCollisionEnter(Collision collision)
    {
        // Game Overと表示する
        gameOverMessage.text = "Game Over";
        Destroy(collision.gameObject);
    }
}
