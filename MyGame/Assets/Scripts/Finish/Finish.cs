using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private int nextScene;
    public GameObject Text;
    // Start is called before the first frame update
    void Start()
    {
        nextScene = SceneManager.GetActiveScene().buildIndex + 1;

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -60f)
        {
            Text.GetComponent<Renderer>().enabled = true;
            if (transform.position.x < -65f)
            {
                SceneManager.LoadScene(nextScene);
            }
        }

 
       else
        {
            Text.GetComponent<Renderer>().enabled = false;
        }
    }
}
