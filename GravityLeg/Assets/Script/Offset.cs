using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Offset : MonoBehaviour
{
    public float speed;
    Renderer rd;

    private void Start()
    {
        rd = GetComponent<Renderer>();
    }

    private void Update()
    {
        rd.material.mainTextureOffset -= new Vector2(speed * Time.deltaTime, 0);
    }
}
