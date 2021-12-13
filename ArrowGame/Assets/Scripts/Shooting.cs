using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject arrow_prefab;
    float arrowImpulse = 50f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Camera cam = Camera.main;
            GameObject theArrow = (GameObject)Instantiate(arrow_prefab, cam.transform.position + cam.transform.forward, cam.transform.rotation);
            theArrow.GetComponent<Rigidbody>().AddForce(cam.transform.forward * arrowImpulse, ForceMode.Impulse);
            
        }
        
    }
}
