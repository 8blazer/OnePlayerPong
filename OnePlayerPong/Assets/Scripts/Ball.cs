using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Ball : MonoBehaviour
{
    public float speed;
    float xCompare = 0;
    float yCompare = 0;
    public GameObject platform;
    public GameObject arrow;
    float timer = 0;
    System.Random rnd = new System.Random();
    // Start is called before the first frame update
    void Start()
    {
        int i = rnd.Next(-15, 16);
        transform.position = new Vector3(i / 10, 0, 0);
        i = rnd.Next(-15, 16);
        transform.position = new Vector3(transform.position.x, i / 10, 0);
        i = rnd.Next(1, 5);
        if (i == 1)
        {
            transform.Rotate(0, 0, 90);
        }
        else if (i == 2)
        {
            transform.Rotate(0, 0, -90);
        }
        else if (i == 3)
        {
            transform.Rotate(0, 0, 180);
        }
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody2D>().velocity = transform.up * speed;
        timer += Time.deltaTime;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Platform" && timer > .2f)
        {
            if (PlatformMovement.rounded == 0)
            {
                xCompare = transform.position.x - platform.transform.position.x;
                    if (xCompare < 0)
                    {
                        transform.Rotate(new Vector3(0, 0, -90));
                    }
                    else
                    {
                        transform.Rotate(new Vector3(0, 0, 180));
                    }
                speed = speed + .1f;
                timer = 0;
            }
            else if (PlatformMovement.rounded == 180)
            {
                xCompare = transform.position.x - platform.transform.position.x;
                if (xCompare > 0)
                {
                    transform.Rotate(new Vector3(0, 0, -90));
                }
                else
                {
                    transform.Rotate(new Vector3(0, 0, 180));
                }
                speed = speed + .1f;
                timer = 0;
            }
            else if (PlatformMovement.rounded == 90)
            {
                yCompare = transform.position.y - platform.transform.position.y;
                if (yCompare < 0)
                {
                    transform.Rotate(new Vector3(0, 0, -90));
                }
                else
                {
                    transform.Rotate(new Vector3(0, 0, 180));
                }
                speed = speed + .1f;
                timer = 0;
            }
            else
            {
                yCompare = transform.position.y - platform.transform.position.y;
                if (yCompare > 0)
                {
                    transform.Rotate(new Vector3(0, 0, -90));
                }
                else
                {
                    transform.Rotate(new Vector3(0, 0, 180));
                }
                speed = speed + .1f;
                timer = 0;
            }
        }
        else
        {
            SceneManager.LoadScene("Lose");
        }
        /*
        if (collision.gameObject.name == "Platform")
        {
            PlatformMovement.canMove = false;
            arrow.GetComponent<SpriteRenderer>().enabled = true;
        }
        */
    }
}
