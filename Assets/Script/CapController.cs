using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapController : MonoBehaviour
{
    // Start is called before the first frame update
    public string keyTag = "ChestKey";
    public Animator capAnimator;

    private bool isOpen = false;

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag(keyTag) && !isOpen)
        {
            OpenChest();
            Debug.Log("oepnChest SUCCESSS");
        }
    }

    // Update is called once per frame
    private void OpenChest()
    {
        capAnimator.SetTrigger("OpenCap");
        isOpen = true;

    }
}
