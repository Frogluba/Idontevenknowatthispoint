using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    public float speed;
    public Vector3 spawnPoint;
    
    void Start()
    {
        spawnPoint = transform.position;
    }

 
    void Update()
    {
        Vector3 moveDirection = new Vector3();
        moveDirection.x = Input.GetAxisRaw("Horizontal");
        moveDirection.z = Input.GetAxisRaw("Vertical");
        

        transform.position += moveDirection * speed * Time.deltaTime;
        //GetComponent<Rigidbody>().velocity = moveDirection * speed;
        if (moveDirection != Vector3.zero )  transform.forward = moveDirection;  //rotate player awsd direction
  
    }
    public void Die()
    {
        transform.position = spawnPoint;
    }
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.name.Contains("Enemy"))
        {
            var currentScene = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene(currentScene);
        }
    }
}
