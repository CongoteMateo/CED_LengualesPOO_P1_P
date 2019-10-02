using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
    public Transform spawnPosition;
    public Rigidbody cannonBall;
    public float force = 5F;
    private float CurrentHealth;
    public Image ImagenAragana;

    public float health;

    protected void FireBullet()
    {
        Rigidbody cannonBallClone =
            Instantiate<Rigidbody>(
                cannonBall, spawnPosition.position, spawnPosition.rotation);

        cannonBallClone.AddForce(transform.forward * force, ForceMode.Impulse);
    }
    void Start()
    {
        CurrentHealth = health;
    }

    public void ApplyDamage(int damageValue)
    {
        
        CurrentHealth -= damageValue;

        ImagenAragana.fillAmount = CurrentHealth / health;

        if (CurrentHealth <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Game_Over", LoadSceneMode.Single);
        }
    }   
}
