using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    public GameObject ProjectilePrefab;
    public GameObject gameOverPanel;
    public Text gameOverText;


    // Use this for initialization
    void Start()
    {
        gameOverPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            StartCoroutine(SpawnProjectile());
        }
    }

    IEnumerator SpawnProjectile()
    {


        Instantiate(ProjectilePrefab, transform.position, Quaternion.identity);

        int WaitTime = 0;
        yield return new WaitForSeconds(WaitTime);
        
        if (Input.GetKeyDown("space"))
        {
            StartCoroutine(SpawnProjectile());
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bird")
        {

            Destroy(gameObject);
            Score.ScoreVal = 0;
            gameOverPanel.SetActive(true);

        }
    }
}
