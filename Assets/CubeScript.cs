using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    public Vector3 positionChange;
    public Vector3 rotateChange;
    public Vector3 scaleChange;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += positionChange;
        transform.Rotate(rotateChange);
        transform.localScale += scaleChange;
    }
}
