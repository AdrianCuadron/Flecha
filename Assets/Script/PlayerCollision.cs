using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public GameObject dieParticles;
    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("End"))
        {
            this.final();
        }
        gameObject.SetActive(false);
        Instantiate(dieParticles, transform.position, Quaternion.identity);
        gameManager.died();
        Destroy(gameObject);
    }

    private void final()
    {
        
    }
    
}
