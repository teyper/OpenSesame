using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gatescript : MonoBehaviour
{
     Animator animator;
    
    // Start is called before the first frame update
    void Start()
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
    }

    private void OnTriggerExit(Collider other)
    {
        animator.Play("closeSesame1");
    }

    public void OnPowerUp()
    {
        animator.Play("openSesame");
    }
}
