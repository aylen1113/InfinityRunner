using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class PlayerMovement : MonoBehaviour
{
   public float speed = 5;
   public Rigidbody rb;
    float horizontalInput;
    public float horizontalMultiplier = 2;
    bool alive = true;



    private void FixedUpdate()
    {
        if (!alive) return;
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime * horizontalMultiplier;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);

    }
    private void Update()
    {
         horizontalInput = Input.GetAxis("Horizontal");

        if (transform.position.y < -5)
        {
            Death();
        }
    }


    public void Death()
    {
        alive = false;
       
        Invoke("Restart", 2);
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}


