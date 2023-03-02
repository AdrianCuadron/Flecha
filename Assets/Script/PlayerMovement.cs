using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rd;
    public float velocity;

    public GameObject dieParticles;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = new Quaternion(0f, 1.0f, 0f, 0f);
        if (Input.GetMouseButton(0))
        {
            

            if (transform.position.y > 4.7f)
            {
                rd.velocity = new Vector3(velocity, 0, 0);
                gameObject.transform.rotation = Quaternion.identity;
                
            }
            else
            {
                
                rd.velocity = new Vector3(velocity, Mathf.Sqrt(3f) * velocity, 0);
                gameObject.transform.rotation = Quaternion.Euler(0f, 0f, 60f);
            }
        }

        else
        {
            if (transform.position.y < -4.7f)
            {
                
                rd.velocity = new Vector3(velocity, 0, 0);
                gameObject.transform.rotation = Quaternion.identity;
            }
            else
            {
                
                rd.velocity = new Vector3(velocity, -Mathf.Sqrt(3f) * velocity, 0);
                gameObject.transform.rotation = Quaternion.Euler(0f, 0f, -60f);
            }
            
            
        }

       
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "rapido")
        {
            velocity = velocity + 2;
        }

        else if(collision.gameObject.tag == "lento")
            {
                velocity = velocity - 2;
            }

        else if (collision.gameObject.tag == "normal")
        {
            velocity = 6;
        }

        else if (collision.gameObject.tag == "end")
        {
            gameObject.SetActive(false);
            Instantiate(dieParticles, transform.position, Quaternion.identity);
            
            Destroy(gameObject);
        }

    }


    
}
