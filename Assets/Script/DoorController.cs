using UnityEngine;

public class DoorController : MonoBehaviour
{
    public string keyTag = "Key";
    public Animator doorAnimator;
    public GameObject bricks;

    private bool isOpen = false;

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag(keyTag) && !isOpen)
        {
            OpenDoor();
            Debug.Log("oepndoor SUCCESSS");
        }
    }

    private void OpenDoor()
    {
        Destroy(bricks);
        doorAnimator.SetTrigger("Open");
        isOpen = true;

    }

}
