using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class gatescript : MonoBehaviour
{
     Animator animator;
    public UnityEvent PowerUp;
    

    // Start is called before the first frame update
    public void Start()
    {
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        animator.Play("openSesame");
        animator.Play("longOpen");
      

    }

    private void OnTriggerExit(Collider other)
    {
        animator.Play("closeSesame");
        animator.Play("longClose");

    }

    public void OnPowerUp()
    {
        animator.Play("openSesame");
        Debug.Log("yes!");

    }


    
}
