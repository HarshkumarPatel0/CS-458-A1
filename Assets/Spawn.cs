using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    // This script will simply instantiate the Prefab when the game starts.
    // Reference to the Prefab. Drag a Prefab into this field in the Inspector.
    public GameObject redCube;
    public GameObject blueCube;
    public float timer;
    public Vector3 left = new Vector3(-3, 0, 0);
    public Vector3 right = new Vector3(3, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        // Instantiate at position (0, 0, 0) and zero rotation.
        // Instantiate(redCube, new Vector3(0, 0, 0), Quaternion.identity);
        // Instantiate(blueCube, new Vector3(0, 0, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            Rigidbody cube;
            Vector3 speed;
            GameObject which;
            int rnd = Random.Range(0, 2);
            Debug.Log($"Color:{rnd}");

            if (rnd != 0)
            {
                which = redCube;
            }
            else
            {
                which = blueCube;
            }

            rnd = Random.Range(0, 2);
            Debug.Log($"Direction:{rnd}");

            if (rnd != 0)
            {
                speed = left;
            }
            else
            {
                speed = right;
            }

            //speed = (new Vector3(Random.Range(-5, 5), 0, 0));

            //cube = Instantiate(which, (new Vector3(Random.Range(-3, 3), 0, 0)), transform.rotation).GetComponent<Rigidbody>();
            cube = Instantiate(which, (new Vector3(0, 0, 0)), transform.rotation).GetComponent<Rigidbody>();
            cube.AddForce(speed);

            //Instantiate(blueCube, new Vector3(0, 0, 0), Quaternion.identity);
            timer = 2;
        }

    }
}
