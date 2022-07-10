using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float curtime = 0;
    public float maxtime;
    public GameObject obstacle;
    public float height;
    public float d;

    private void Start()
    {
        GameObject newobstacle = Instantiate(obstacle);
        newobstacle.transform.position = new Vector2(0, transform.position.y + Random.Range(-height - d, height + d));    
    }
    private void Update()
    {
        if(curtime > maxtime)
        {
            GameObject newobstacle = Instantiate(obstacle);
            newobstacle.transform.position = new Vector2(0, transform.position.y + Random.Range(-height - d, height + d));
            curtime = 0;
            Destroy(newobstacle, 10);
        }

        
        curtime += Time.deltaTime;
    }
    
}