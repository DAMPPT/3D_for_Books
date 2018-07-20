using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RotateObject1 : MonoBehaviour
{
    public float rotateSpeed = 50f;
    bool rotateStatus = false;
    private GameObject[] spheres;


    void Start()
    {
        spheres = GameObject.FindGameObjectsWithTag("Sphere");
    }

    public void Rotasi()
    {

        if (rotateStatus == false)
        {
            rotateStatus = true;
        }
        else
        {
            rotateStatus = false;
        }
    }

    void Update()
    {
        if (rotateStatus == true)
        {
            foreach (GameObject objectRotate in spheres)
            {
                objectRotate.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
            }
           
        }
    }
}
