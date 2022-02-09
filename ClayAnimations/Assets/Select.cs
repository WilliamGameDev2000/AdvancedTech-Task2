using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select : MonoBehaviour
{
    bool selected = false;

    private void OnMouseDown()
    {
       selected = true;
        Debug.Log("Selected:" + gameObject.name);
    }
}
