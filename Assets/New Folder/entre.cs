using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class entre : MonoBehaviour
{
    GameObject player;
    bool kanG�Ind = false;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && kanG�Ind)
        {
            SceneManager.LoadScene("hus");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("collide");
        if(collision.gameObject.Equals(player))
        {
            kanG�Ind = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("uncollide");

        if (collision.gameObject.Equals(player))
        {
            kanG�Ind = false;
        }
    }


}
