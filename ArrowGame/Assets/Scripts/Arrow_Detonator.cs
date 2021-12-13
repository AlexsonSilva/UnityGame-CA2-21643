using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Arrow_Detonator : MonoBehaviour
{
    float lifespan = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        lifespan -= Time.deltaTime;
        if(lifespan <= 0)
        {
            Explode();
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ballon")
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
            SceneManager.LoadScene(1);
        }
    }

     void Explode()
    {
        Destroy(gameObject);
    }
}
