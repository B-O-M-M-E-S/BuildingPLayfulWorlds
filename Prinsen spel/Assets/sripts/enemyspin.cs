using UnityEngine;
using System.Collections;
public class EnemyTwo : MonoBehaviour
{
    public float health = 50f;
    public float speed = 10f;
    public float enemyDamage;
    public float fpsTargetDistance;
    public float enemyLookDistance;
    public float attackDistance;
    public float enemyMovementSpeed;
    public float damping;
    public Transform fpsTarget;
    Rigidbody theRigidbody;
    Renderer myRender;


    void Start()
    {
        myRender = GetComponent<Renderer>();
        theRigidbody = GetComponent<Rigidbody>();

    }

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {

        transform.Rotate(Vector3.up, speed * Time.deltaTime);

    }
}