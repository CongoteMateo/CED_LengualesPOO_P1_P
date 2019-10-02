using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Character : MonoBehaviour
{
    public Transform spawnPosition;
    public Rigidbody cannonBall;
    public float force = 5F;    

    public int health;

    protected void FireBullet()
    {
        Rigidbody cannonBallClone =
            Instantiate<Rigidbody>(
                cannonBall, spawnPosition.position, spawnPosition.rotation);

        cannonBallClone.AddForce(transform.forward * force, ForceMode.Impulse);
    }

    public void ApplyDamage(int damageValue)
    {
        health -= damageValue;

        if (health <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("Game_Over", LoadSceneMode.Single);
        }
    }    
}
