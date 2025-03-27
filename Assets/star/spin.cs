using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;



public class spin : MonoBehaviour
{
    [SerializeField] float speed = 360f;
    // Start is called before the first frame update

    public UnityEvent PowerUp;
    GameObject[] obj;
    

void Start()
    {

      obj = GameObject.FindGameObjectsWithTag("gate");
        if (obj != null)
        {
            foreach (GameObject gate in obj)
            {
                PowerUp.AddListener(gate.GetComponent<gatescript>().OnPowerUp);

            }
          
        }

    }

    // Update is called once per frame
    
    void Update()
    {
        transform.Rotate(speed * Time.deltaTime * Vector3.forward);
    }


    

    public void OnPowerUp()
    {
        Debug.Log("Star Power Up activated!");
        //PowerUp.Invoke();
    }

    private void OnTriggerEnter(Collider other)
    {
        PowerUp.Invoke();
        Debug.Log("hey girl");
        Destroy(gameObject);

    }

}
