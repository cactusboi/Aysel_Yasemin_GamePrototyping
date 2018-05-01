using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour {

    public GameObject BirdPrefab;
    public GameObject Spawner;

	// Use this for initialization
	void Start () {

        StartCoroutine(SpawnBird());

	}
	
	// Update is called once per frame
	void Update () {


	}

    IEnumerator SpawnBird()
    {
        

        Instantiate(BirdPrefab, transform.position, Quaternion.identity);

        int WaitTime = Random.Range(0, 5);
        yield return new WaitForSeconds(WaitTime);

        StartCoroutine(SpawnBird());
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Destructible")
        {
            Destroy(gameObject);
        }


    }





}
