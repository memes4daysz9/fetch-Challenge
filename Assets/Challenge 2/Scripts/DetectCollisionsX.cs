using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{

    private void OnTriggerEnter(Collider other) //any time something collides with this scripts hitbox, it will destroy
    {
        Destroy(gameObject);
    }
}
