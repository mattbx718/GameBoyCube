using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MouseClicker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))   //if left button is pressed
        {
            Debug.Log("Left Click");        // show in console
            SceneManager.LoadScene("Level1");      
        }

        if (Input.GetMouseButtonDown(1))   //if right button is pressed
        {
            Debug.Log("Right Click");     // show in console
            SceneManager.LoadScene("Level1");         
        }

        if (Input.GetMouseButtonDown(2))   //if middle button is pressed
        {
            Debug.Log("Middle Click");    // show in console
            SceneManager.LoadScene("Level1");        
        }
    }
}
