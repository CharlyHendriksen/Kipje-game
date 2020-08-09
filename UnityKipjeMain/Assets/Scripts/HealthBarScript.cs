using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarScript : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;
    public PlayerHealth healthBar;
    public GameObject LoseMenuUI;
    public Camera_Shake camera_Shake;

    public GameObject Particle;

    public GameObject explosionEffect;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        Particle.SetActive(false);
        explosionEffect.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {       
    }

      private void OnTriggerEnter(Collider other) //Picks up items labled with tag 'Pick Up'
        {
            if (other.gameObject.CompareTag("Enemy"))
            {
              

                FindObjectOfType<AudioManager>().Play("EnemyHit");
                TakeDamage(20);
                StartCoroutine(camera_Shake.Shake(.15f, .4f));
                Particle.SetActive(true);
                explosionEffect.SetActive(true);
            }

        }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);

        if (currentHealth < 0)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true; 
            Time.timeScale = 0f;
            LoseMenuUI.SetActive(true);
        }
    }
}
