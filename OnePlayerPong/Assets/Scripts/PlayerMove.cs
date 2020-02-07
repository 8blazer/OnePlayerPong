using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMove : MonoBehaviour
{

    void Start()
    {
    }
    void Update()
    {
        if (transform.position.x > 5)
        {
            SceneManager.LoadScene("Game");
        }
    }
}
