using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Points : MonoBehaviour
{
    public TextMeshProUGUI Text;

    private void Start()
    {
        Text = GetComponent<TextMeshProUGUI>();
    }
}
