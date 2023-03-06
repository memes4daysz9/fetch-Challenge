using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardX : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {//tells animals and wine to move forward
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
