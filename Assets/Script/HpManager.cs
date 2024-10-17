using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpManager : MonoBehaviour
{
    public int maxHealth = 6;  // 最大血量 // Max health
    public int currentHealth;   // 当前血量 // Current health

    public Slider healthBar;     // 血条的引用 // Reference to the health bar
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;  // 初始化血量为最大值 // Initialize health to max value
        healthBar.maxValue = maxHealth;  // 设置血条的最大值 // Set the health bar's max value
        healthBar.value = currentHealth; // 初始化血条的当前值 // Set the health bar's current value
        Debug.Log("born" );
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;  // 扣血 // Subtract damage from health

        if (currentHealth <= 0)
        {
            Die();  // Call the Die function when health reaches 0
        }

         // Update the health bar
        healthBar.value = currentHealth;
    }

    void Die()
    {
        Debug.Log("Player Died!");
        // Implement what happens when the player dies
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collided with: " + collision.gameObject.name);
        // 检查碰撞的物体是否是伤害来源（例如敌人、陷阱等） // Check if the object collided with is the source of damage
        if (collision.gameObject.CompareTag("Enemy"))  // 假设敌人有标签 "Enemy" // Assuming the enemy has a tag "Enemy"
        {
            TakeDamage(1);   // Subtract 1 health points
        }
    }

   



    // Update is called once per frame

}
