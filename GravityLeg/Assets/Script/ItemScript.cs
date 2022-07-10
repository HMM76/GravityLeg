using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{
    CircleCollider2D cc;
    public GameObject item;
    public float curtime = 0;
    public float maxtime;
    public float temptime;
    public bool tempbool = true;


    

    private void Start()
    {
        curtime = 0;

        
    }

    private void Update()
    {
        if (curtime > temptime && tempbool == true)
        {
            GameObject newitem = Instantiate(item);
            tempbool = false;
            
            Destroy(newitem, 4);
            curtime = 0;
        }
        
        



        if (curtime > maxtime)
        {
            GameObject newitem = Instantiate(item);
            
            Destroy(newitem, 4f);
            curtime = 0;
        }
        curtime = curtime + Time.deltaTime;
        
    }
}
