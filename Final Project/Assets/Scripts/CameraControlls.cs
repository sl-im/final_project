using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControls : MonoBehaviour
{
    // Start is called before the first frame update
   public Transform target;
    public Vector3 posOffset;
        

    void Start()
    {
        posOffset = transform.position - target.transform.position;
    }

    private void LateUpdate()
    {
        transform.position = target.position + posOffset;
    }
}  
