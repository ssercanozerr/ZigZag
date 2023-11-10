using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTracking : MonoBehaviour
{
    public Transform ballPosition;
    Vector3 difference;
    void Start()
    {
        difference = transform.position - ballPosition.position;
    }

    void Update()
    {
        if (BallBehaviourScript.isFall == false)
        {
            transform.position = ballPosition.position + difference;
        }
    }
}