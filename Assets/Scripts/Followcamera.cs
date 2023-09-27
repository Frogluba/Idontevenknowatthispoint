using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Followcamera : MonoBehaviour
{
    public Transform target;
    public float cameraHeight = 35;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position - transform.forward * cameraHeight;
        
    }
}
