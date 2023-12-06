using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int currentHealth;                //declare public integers variables for health
    public int maxHealth;

    public Transform startPos;
    

    // Start is called before the first frame update
    void Start()
    {
        maxHealth = 5;                       //declare health intger value
        currentHealth = maxHealth;          
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TakeDamage(int amount)                //declare integer change on damage collision
    {
        currentHealth -= amount;
        transform.position = new Vector2(startPos.position.x, startPos.position.y);

        if (currentHealth <= 0)                      //condition for health integer value to alter game state 
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}

