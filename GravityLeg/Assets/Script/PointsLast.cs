using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointsLast : MonoBehaviour
{
    public TextMeshProUGUI text;

    private void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

}
