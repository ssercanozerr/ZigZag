using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallBehaviourScript : MonoBehaviour
{
    Vector3 direction;
    public float ballSpeed;
    public float addSpeed;
    public GameObject player;
    public GameObject pause;
    public GameObject panel;
    public static bool isFall;
    public GroundSpawner groundSpawner;

    void Start()
    {
        direction = Vector3.forward;
        isFall= false;
    }


    void Update()
    {
        if (transform.position.y <= 0)
        {
            isFall= true;
            player.SetActive(false);
            pause.SetActive(false);
            panel.SetActive(true);
            
        }
        if (isFall == true)
        {
            return;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (direction.x == 0)
            {
                direction = Vector3.left;
            }
            else
            {
                direction = Vector3.forward;
            }
            ballSpeed += addSpeed * Time.deltaTime;
        }
    }

    private void FixedUpdate()
    {
        Vector3 behavior = direction * Time.deltaTime * ballSpeed;
        transform.position += behavior;
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            ScoreScript.score++;
            collision.gameObject.AddComponent<Rigidbody>();
            groundSpawner.CreateGround();
            StartCoroutine(DeleteGround(collision.gameObject));
        }
    }

    IEnumerator DeleteGround(GameObject deleteGround)
    {
        yield return new WaitForSeconds(3f);
        Destroy(deleteGround);
    }
}
