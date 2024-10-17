using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpManager : MonoBehaviour
{
    public int maxHealth = 6;  // ���Ѫ�� // Max health
    public int currentHealth;   // ��ǰѪ�� // Current health

    public Slider healthBar;     // Ѫ�������� // Reference to the health bar
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;  // ��ʼ��Ѫ��Ϊ���ֵ // Initialize health to max value
        healthBar.maxValue = maxHealth;  // ����Ѫ�������ֵ // Set the health bar's max value
        healthBar.value = currentHealth; // ��ʼ��Ѫ���ĵ�ǰֵ // Set the health bar's current value
        Debug.Log("born" );
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;  // ��Ѫ // Subtract damage from health

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
        // �����ײ�������Ƿ����˺���Դ��������ˡ�����ȣ� // Check if the object collided with is the source of damage
        if (collision.gameObject.CompareTag("Enemy"))  // ��������б�ǩ "Enemy" // Assuming the enemy has a tag "Enemy"
        {
            TakeDamage(1);   // Subtract 1 health points
        }
    }

   



    // Update is called once per frame

}
