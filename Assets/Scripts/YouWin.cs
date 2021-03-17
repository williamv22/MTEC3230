using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YouWin : MonoBehaviour
{

    public GameObject collected;
    public int objects;
    


    // Start is called before the first frame update
    void Start()
    {
        collected.SetActive(false);   
    }

    // Update is called once per frame
    void Update()
    {
     if(objects == 0)
        {
            collected.SetActive(true);
        }
    }
}
