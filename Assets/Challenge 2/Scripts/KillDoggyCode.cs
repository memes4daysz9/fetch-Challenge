using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillDoggyCode : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject doggy;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   private void OnTriggerEnter(Collider other)//if somthing touches the dog... the dog will die
    {
        Destroy(doggy);
        
    }
}
