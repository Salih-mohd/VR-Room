using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reticle : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        if(gameObject.activeInHierarchy)
        transform.Rotate(Vector3.up*speed*Time.deltaTime);
    }
}
