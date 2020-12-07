using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public Transform sphere;
    void Start()
    {
        
    }

    void Update()
    {
        //direccion = objetivo - punto inicial
        Vector3 direction = sphere.position - transform.position;
        //Direccion en la que mirar
        Quaternion look = Quaternion.LookRotation(direction);
        //Hacer que la rotacion mire hacia la esfera y que se mueva mas lento con Time.deltaTime
        transform.rotation = Quaternion.Slerp(transform.rotation, look, Time.deltaTime);
    }
}
