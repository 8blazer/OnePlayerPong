using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Movement : MonoBehaviour
{
    public Joystick joystick;
    public static float gas = 10;
    float horizontalMove = 0;
    float verticalMove = 0;
    public float speed = 1;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gas > 0)
        {
            GetComponent<Rigidbody2D>().gravityScale = 0;
            if (joystick.Horizontal > .2)
            {
                horizontalMove = 1;
            }
            else if (joystick.Horizontal < -.2)
            {
                horizontalMove = -1;
            }
            else
            {
                horizontalMove = 0;
            }
            if (joystick.Vertical > .2)
            {
                verticalMove = 1;
            }
            else if (joystick.Vertical < -.2)
            {
                verticalMove = -1;
            }
            else
            {
                verticalMove = 0;
            }
            gas -= Time.deltaTime;
            if (gas < 0)
            {
                gas = 0;
            }
            GetComponent<Rigidbody2D>().velocity = new Vector2(horizontalMove * speed, verticalMove * speed);
        }
        else
        {
            horizontalMove = 0;
            verticalMove = 0;
            GetComponent<Rigidbody2D>().gravityScale = 1;
        }
        text.text = "Gas: " + gas;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        gas = 10;
    }
}
