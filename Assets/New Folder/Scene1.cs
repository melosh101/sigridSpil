using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene1 : MonoBehaviour
{

    public List<GameObject> døre = new();
    // Start is called before the first frame update
    void Start()
    {
        // så tjek om spiller kommer fra huset
        if (PlayerPrefs.HasKey("door"))
        {
            Debug.Log(PlayerPrefs.GetInt("door"));
            var dørNum = PlayerPrefs.GetInt("door");
            if(dørNum == 0) return; 
            var dør = døre.ElementAt(dørNum -1);
            Debug.Log($"antal døre i scene: {døre.Count}");
            Debug.Log($"dør: {dør.name}");

            // set spiller i døren
            GameObject.Find("Player").transform.position = dør.transform.position;
        }

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
