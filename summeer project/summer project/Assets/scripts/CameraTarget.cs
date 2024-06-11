using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTarget : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target; //camera position
    public Vector3 posOffset; //target distannce from the camera
    void Start()
    {
        
    }

    // Update is called once per frame
   private void LateUpdate()
    {
        transform.position = target.position + posOffset;
    }
}
