using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeformMesh : MonoBehaviour
{

    Vector3[] original_vertex_positions;
    Vector3[] vertex_positions;

    Transform[] bone_collection;
    void Awake()
    {
        original_vertex_positions = gameObject.GetComponentInChildren<SkinnedMeshRenderer>().sharedMesh.vertices;
        bone_collection = gameObject.GetComponentInChildren<SkinnedMeshRenderer>().bones;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log(bone_collection[0]);
        }
        
        if(Input.GetKeyDown(KeyCode.R))
        {
            ResetVertices();
        }
    }

    void ResetVertices()
    {
        vertex_positions = original_vertex_positions;
    }
}
