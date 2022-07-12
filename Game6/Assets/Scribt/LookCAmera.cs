using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookCAmera : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Quaternion rotation = transform.localRotation;
        rotation.x += 0.05f * Input.GetAxis("Mouse Y");

        if (rotation.x > 0.3f)
            rotation.x = 0.3f;
        else if (rotation.x < -0.4f)
            rotation.x = -0.4f;

        rotation.y = 0;
        rotation.z = 0;

        transform.localRotation = rotation;

        Debug.Log("Transform.Position: " + transform.position); 
        Debug.Log("Transform.localPosition: " + transform.localPosition);

    }
}
