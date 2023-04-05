using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dørUd : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject player;
    private bool canExit;
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && canExit)
        {
            // vælg dør spiller skal komme ud af
            PlayerPrefs.SetInt("door", 1);
            SceneManager.LoadScene("Undervisning");
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.Equals(player)) canExit = true;
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.Equals(player)) canExit = false;
    }
}
