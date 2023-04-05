    using System;
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.SceneManagement;

    public class entre : MonoBehaviour
    {
        GameObject player;
        bool canEnter = false;
        // Start is called before the first frame update
        void Start()
        {
            Debug.Log("hello from house");
            player = GameObject.Find("Player");
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.W) && canEnter)
            {
                SceneManager.LoadScene("hus");
            }
        }

        private void OnTriggerEnter2D(Collider2D collider)
        {
            if (collider.gameObject.Equals(player)) canEnter = true;
        }

        private void OnTriggerExit2D(Collider2D collider)
        {
            if (collider.gameObject.Equals(player)) canEnter = false;
        }
    }
