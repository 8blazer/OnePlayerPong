using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlatformMovement : MonoBehaviour
{
    public Joystick joystick;
    public float speed;
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
                transform.position = transform.position + new Vector3(speed, 0, 0);
            }
            else if (transform.rotation.eulerAngles.z == 90)
            {
                transform.position = transform.position + new Vector3(0, speed, 0);
            }
            else if (transform.rotation.eulerAngles.z == 180)
            {
                transform.position = transform.position + new Vector3(-speed, 0, 0);
            }
            else
            {
                transform.position = transform.position + new Vector3(0, -speed, 0);
            }
        }
        if (joystick.Horizontal < -.2)
        {
            if (transform.rotation.eulerAngles.z == 0)
            {
                transform.position = transform.position + new Vector3(-speed, 0, 0);
            }
            else if (transform.rotation.eulerAngles.z == 90)
            {
                transform.position = transform.position + new Vector3(0, -speed, 0);
            }
            else if (transform.rotation.eulerAngles.z == 180)
            {
                transform.position = transform.position + new Vector3(speed, 0, 0);
            }
            else
            {
                transform.position = transform.position + new Vector3(0, speed, 0);
            }
        }
        if (transform.position.x > 5)
        {
            transform.position = new Vector3(5, transform.position.y, 0);
        }
    }
}
