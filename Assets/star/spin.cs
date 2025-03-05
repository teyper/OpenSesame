using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class spin : MonoBehaviour
{
    [SerializeField] float speed = 360f;
    // Start is called before the first frame update

public UnityEvent PowerUp;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(speed * Time.deltaTime * Vector3.forward);
    }

    private void OnTriggerEnter(Collider other)
    {
        PowerUp.Invoke();
    }
}
