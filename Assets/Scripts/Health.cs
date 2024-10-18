using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    
    public float maxHealth = 100f;
 
    private float currentHealth;

   
    public Slider healthBar;

   
    public GameObject youDieUI;

    public GameObject player;

    void Start()
    {
        
        currentHealth = maxHealth;
       
        UpdateHealthBar();

       
        youDieUI.SetActive(false);
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Debug.Log("Enemy triggered!");
            TakeDamage(20f);
        }
    }


    void TakeDamage(float damageAmount)
    {
        
        currentHealth -= damageAmount;
        Debug.Log("Player Health--");


        UpdateHealthBar();

        if (currentHealth > 0)
        {
            
            OVRPlayerControllerCustomize playerController = player.GetComponent<OVRPlayerControllerCustomize>();
            if (playerController != null)
            {
                // 调用跳跃并推向反方向
                playerController.JumpBackwards();
            }
        }

        if (currentHealth <= 0)
        {
            Die();
        }
    }

   
    void UpdateHealthBar()
    {
        healthBar.value = currentHealth / maxHealth;
    }

   
    void Die()
    {
        
        youDieUI.SetActive(true);

        
    }
}