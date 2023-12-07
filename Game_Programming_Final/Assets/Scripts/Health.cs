using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.ComponentModel;

public class Health : MonoBehaviour
{
    public int currentHealth;                //variables for health
    public int maxHealth;
    public int maxLives;                     //variables for lives
    public int currentLives;

    public Image[] lifeImages;               // Changed to array
    public Image[] healthImages;             // Changed to array
    public Transform startPos;

    public string healthTag = "Health";
    public string lifeTag = "Life";

    public Color lifeColor = Color.green;
    public Color healthColor = Color.red;
    public Color inactiveColor = Color.grey;


    // Start is called before the first frame update
    void Start()
    {
        healthImages = GetComponents<Image>();   // Changed to GetComponents
        lifeImages = GetComponents<Image>();     // Changed to GetComponents
        maxHealth = 5;                           //health value
        currentHealth = maxHealth;

        maxLives = 3;                            //lives value
        currentLives = maxLives;
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < lifeImages.Length; i++)
        {
            if (i < currentLives)
            {
                lifeImages[i].color = lifeColor;
            }
            else
            {
                lifeImages[i].color = inactiveColor;  // Added else condition to handle inactive lives
            }
        }
    }

    public void TakeDamage(int amount)                //declare integer change on damage collision
    {
        currentHealth -= amount;
        transform.position = new Vector2(startPos.position.x, startPos.position.y);

        if (currentHealth <= 0)                      //condition for health integer value to alter game state 
        {
            currentLives--;                           // Decrease lives when health reaches 0
            if (currentLives <= 0)
            {
                SceneManager.LoadScene("GameOver");
            }
            else
            {
                currentHealth = maxHealth;            // Reset health when lives are still available
            }
        }
    }
    public class PlayerBoundaryCheck : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Boundary"))         //Game Over on boundary collision
            {
                
                SceneManager.LoadScene("GameOver");
            }
        }
    }

}


