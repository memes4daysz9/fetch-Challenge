using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    //variables
    private float bottomLimit = -5;
    private float leftLimit = -40;
    

    // Update is called once per frame
    void Update()
    {
        
        
        // Destroy balls if y position is less than bottomLimit
        if (transform.position.y < bottomLimit)
        {
            Destroy(gameObject);
        }
        // Destroy dogs if x position less than left limit
        else if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        }

    }
}
