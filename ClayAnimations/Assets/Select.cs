using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Select : MonoBehaviour
{
    [SerializeField]
    private bool selected = false;

    public void SetSelected(bool set)
    {
        selected = set;
    }

    public bool GetSelected()
    {
        return selected;
    }
}
