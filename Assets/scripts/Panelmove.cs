using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panelmove : MonoBehaviour

{
    public Transform target;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Vector3 a = transform.position;
        Vector3 b = target.position;
        transform.position = Vector3.MoveTowards(a, b, speed);
    }
   
}
