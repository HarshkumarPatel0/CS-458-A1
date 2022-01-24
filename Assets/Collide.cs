using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collide : MonoBehaviour
{
    private string color;

    // Start is called before the first frame update
    void Start()
    {
        color = GetComponent<Color>().color;
        Debug.Log($"Color:{color}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	
    void OnTriggerEnter(Collider other)
	{
        if (color == other.GetComponent<Color>().color)
        {
            Destroy(other.gameObject);
        }
    }	
}
