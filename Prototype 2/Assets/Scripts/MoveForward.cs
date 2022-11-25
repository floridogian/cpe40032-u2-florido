using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    // Public Variable
    public float speed; // the speed of the objects
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the objects forward at certain speed 
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
