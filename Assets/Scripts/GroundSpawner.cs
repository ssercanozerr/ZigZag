using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject lastGround;
    void Start()
    {
        for (int i = 0; i < 30; i++)
        {
            CreateGround();
        }
    }

    public void CreateGround()
    {
        Vector3 groundDirection;
        if (Random.Range(0, 2) == 0)
        {
            groundDirection = Vector3.left;
        }
        else
        {
            groundDirection = Vector3.forward;
        }
        lastGround = Instantiate(lastGround, lastGround.transform.position + groundDirection, lastGround.transform.rotation);
    }
}
