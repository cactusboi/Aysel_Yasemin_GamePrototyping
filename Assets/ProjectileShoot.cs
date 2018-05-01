using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileShoot: MonoBehaviour {

    public Vector3 MoveSpeed;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

       transform.position -= MoveSpeed;

    }

        private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Destructible")
        {
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag == "Bird")
        {
            Destroy(gameObject);
        }
    }
}
