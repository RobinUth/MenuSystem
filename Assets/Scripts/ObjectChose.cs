using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectChose : Cube {


    public GameObject cube;
    public GameObject sphere;
    public GameObject capsule;


    [SerializeField] GameObject stack;


    private void Start()
    {

        SpawnObject(cube);

    
    }
    public void NewObject()
    {

        size = 1;
        speed = 10;
    }


    public void SpawnObject(GameObject prefab)
    {
        GameObject child = Instantiate(prefab);
        if(stack)
        {
            child.transform.parent = stack.transform;
        }


    }

    public void CubeSpawn()
    {
        /*
        NewObject();
        cube.SetActive(true);
        sphere.SetActive(false);
        capsule.SetActive(false);
        */


        SpawnObject(cube);
        

        


    }

    public void SphereSpwan()
    {
        /*
        NewObject();
        cube.SetActive(false);
        sphere.SetActive(true);
        capsule.SetActive(false);*/

        SpawnObject(sphere);
    }

    public void CapsuleSpawn()
    {
        /*
        NewObject();
        capsule.SetActive(true);
        cube.SetActive(false);
        sphere.SetActive(false);
        */

        SpawnObject(capsule);
    }
}
