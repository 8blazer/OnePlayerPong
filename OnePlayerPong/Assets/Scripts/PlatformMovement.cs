using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlatformMovement : MonoBehaviour
{
    public Joystick joystick;
    public float speed;
    bool timerGoing = false;
    float timer = 0;
    bool corner = false;
    bool canRotate = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (joystick.Horizontal > .2)
        {
            if (transform.rotation.eulerAngles.z == 0)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);
            }
            else if (transform.rotation.eulerAngles.z == 90)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
            }
            else if (transform.rotation.eulerAngles.z == 180 || transform.rotation.eulerAngles.z == -180)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, 0);
            }
            else
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, -speed);
            }
        }
        else if (joystick.Horizontal < -.2)
        {
            if (transform.rotation.eulerAngles.z == 0)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, 0);
            }
            else if (transform.rotation.eulerAngles.z == 90)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, -speed);
            }
            else if (transform.rotation.eulerAngles.z == 180 || transform.rotation.eulerAngles.z == -180)
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);
            }
            else
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
            }
        }
        else
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
        }
        if (timerGoing)
        {
            timer += Time.deltaTime;
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        corner = true;
        timerGoing = true;
        if (timer > .1f && corner && canRotate)
        {
            if (collision.gameObject.name == "BottomRight")
            {
                if (transform.rotation.eulerAngles.z == 0)
                {
                    transform.position = new Vector3(6.3f, -3.03f, 0);
                    transform.Rotate(new Vector3(0, 0, 90));
                    timer = 0;
                    canRotate = false;
                }
                else
                {
                    transform.Rotate(new Vector3(0, 0, -90));
                    transform.position = new Vector3(4.83f, -4.7f, 0);
                    timer = 0;
                    canRotate = false;
                }
            }
            else if (collision.gameObject.name == "BottomLeft")
            {
                if (transform.rotation.eulerAngles.z == 0)
                {
                    transform.Rotate(new Vector3(0, 0, -90));
                    transform.position = new Vector3(-6.33f, -3.23f, 0);
                    timer = 0;
                    canRotate = false;
                }
                else
                {
                    transform.Rotate(new Vector3(0, 0, 90));
                    transform.position = new Vector3(-4.91f, -4.7f, 0);
                    timer = 0;
                    canRotate = false;
                }
            }
            else if (collision.gameObject.name == "TopLeft")
            {
                if (transform.rotation.eulerAngles.z == -90)
                {
                    transform.Rotate(new Vector3(0, 0, -90));
                    transform.position = new Vector3(6.33f, 3.23f, 0);
                    timer = 0;
                    canRotate = false;
                }
                else
                {
                    transform.Rotate(new Vector3(0, 0, 90));
                    transform.position = new Vector3(-4.91f, 4.7f, 0);
                    timer = 0;
                    canRotate = false;
                }
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        corner = false;
        timerGoing = false;
        timer = 0;
        canRotate = true;
    }
}
