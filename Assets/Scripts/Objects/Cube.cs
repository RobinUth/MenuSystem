using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cube : MonoBehaviour {

    public float size = 1;
    public float speed = 10;



	
	// Update is called once per frame
	void Update () {

        transform.Rotate(0, speed * Time.deltaTime, 0);

        transform.localScale = new Vector3(size, size, size);
	}

    public void AdjustSpeed(float newSpeed)
    {
        speed = newSpeed;
    }

    public void AdjustSize(float newSize)
    {
        size = newSize;
    }
}
