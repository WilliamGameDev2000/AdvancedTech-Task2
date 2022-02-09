using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeformMesh : MonoBehaviour
{

    private void Start()
    {
        
    }


    [ExecuteInEditMode]


    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        foreach (Transform Bone in gameObject.GetComponentInChildren<SkinnedMeshRenderer>().bones)
        {
            if (Bone.parent != gameObject.GetComponentInChildren<SkinnedMeshRenderer>().bones[0])
            {
                Gizmos.DrawLine(Bone.position, Bone.parent.position);
                Gizmos.DrawLine(Bone.parent.position, Bone.position);
            }
            else
            {
                Gizmos.DrawLine(Bone.GetChild(0).position, Bone.position);
                Gizmos.DrawLine(Bone.position, Bone.GetChild(0).position);
            }
        }
    }
    }
