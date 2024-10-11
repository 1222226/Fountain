using UnityEngine;

public class GrabbedObjectTrigger : MonoBehaviour
{

    public GameObject MappingBlock;
    public GameObject GameFlow;
    private void OnTriggerEnter(Collider other)
    {
        string thisObjectName = gameObject.name;
        Debug.Log("OringinObjectName: " + thisObjectName);
       thisObjectName = gameObject.name.Replace("Colider", "").Trim();
        string colliderObjectName = other.gameObject.name.Replace("(Clone)", "").Trim(); ;

        Debug.Log("thisObjectName: " + thisObjectName);
        Debug.Log("Collider Object: " + colliderObjectName);

        if (thisObjectName == colliderObjectName)
        {
            Debug.Log("Names match, performing actions...");
            Destroy(other.gameObject); 
            MappingBlock.SetActive(true);
            GameFlow.GetComponent<GameFlow>().puzzleMake++;
            if (GameFlow.GetComponent<GameFlow>().puzzleMake == 4)
            {
                GameFlow.GetComponent<GameFlow>().EndGame();
            }
        }
    }
}
