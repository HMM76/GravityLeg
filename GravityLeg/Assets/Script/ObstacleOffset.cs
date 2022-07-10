using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleOffset : MonoBehaviour
{
    public float speed;



    private void Update()
    {
        transform.position -= new Vector3(speed * Time.deltaTime, 0);
    }
}
