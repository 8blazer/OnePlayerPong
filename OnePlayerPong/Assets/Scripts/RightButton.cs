using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class RightButton : MonoBehaviour
{
    public GameObject player;
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onDownsadwesad()
    {
        player.GetComponent<Animator>().SetFloat("x", 1);
        player.transform.position = new Vector3(player.transform.position.x + speed, player.transform.position.y, player.transform.position.z);
    }
    public void onUpasdwe()
    {
        player.GetComponent<Animator>().SetFloat("x", 0);
    }
    public void onDownButActually()
    {
        SceneManager.LoadScene("Game");
    }
}
