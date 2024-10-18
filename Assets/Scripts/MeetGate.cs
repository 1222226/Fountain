using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeetGate : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    void Start()
    { }
        

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Gate"))
        {
            player.transform.position = new Vector3(35, 14, 27);
            }
        else
        {
            Debug.Log(other.gameObject.name);
        }
    }
   

}
