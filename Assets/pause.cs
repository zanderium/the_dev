using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pause : MonoBehaviour
{
    [SerializeField] GameObject canvas;
    bool Pause=false;
    // Start is called before the first frame update
    void Start()
    {
        canvas.SetActive(Pause);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log("Space key was released.");
            Pause = !Pause; 
            canvas.SetActive(Pause);
        }
    }
}
