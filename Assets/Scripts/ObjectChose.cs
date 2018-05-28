using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectChose : Cube {


    public GameObject cube;
    public GameObject sphere;
    public GameObject capsule;


    private void Start()
    {
      
       CubeSpawn();

    
    }
    public void NewObject()
    {

        size = 1;
        speed = 10;
    }

    public void CubeSpawn()
    {
        NewObject();
        cube.SetActive(true);
        sphere.SetActive(false);
        capsule.SetActive(false);
    }

    public void SphereSpwan()
    {
        NewObject();
        cube.SetActive(false);
        sphere.SetActive(true);
        capsule.SetActive(false);
    }

    public void CapsuleSpawn()
    {
        NewObject();
        capsule.SetActive(true);
        cube.SetActive(false);
        sphere.SetActive(false);
    }
}
