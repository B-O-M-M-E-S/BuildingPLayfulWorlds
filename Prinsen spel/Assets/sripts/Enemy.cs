using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
    public bool sound = true;
    public float health = 50f;
    public int enemyDamage;
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
            FindObjectOfType<gameManager>().AddScore();
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);

    }

    void FixedUpdate()
    {
        fpsTargetDistance = Vector3.Distance(fpsTarget.position, transform.position);
        if (fpsTargetDistance < enemyLookDistance)
        {
            myRender.material.color = Color.yellow;
            lookAtPlayer();

            {
                if (fpsTargetDistance < attackDistance)
                {
                    myRender.material.color = Color.red;
                    attackPlease();

                }
                else
                {
                    myRender.material.color = Color.blue;
                }
            }
        }
    }

    void lookAtPlayer()
    {
        Quaternion rotation = Quaternion.LookRotation(fpsTarget.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * damping);
    }

    void attackPlease()
    {
        theRigidbody.AddForce(transform.forward * enemyMovementSpeed);
    }


}
