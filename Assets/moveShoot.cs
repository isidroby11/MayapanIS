using UnityEngine;
using System.Collections;

public class moveShoot : MonoBehaviour
{
    public float speed = 1.0f;
	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position += transform.rotation*((Vector3.forward).normalized * speed * Time.deltaTime);
    }
}
