using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayIn : MonoBehaviour
{
    [SerializeField] GameObject Star;
    private bool starExists = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Return) && !starExists)
        {
            GameObject obj = Instantiate(Star);
            starExists = true;
            //obj.GetComponent<spin>().();
        }

       // if (Input.GetKeyUp(KeyCode.Return)&& starExists)
        //{
           // starExists = false;
        }
    }

   


