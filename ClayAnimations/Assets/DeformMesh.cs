using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class DeformMesh : MonoBehaviour
{
    [SerializeField]SkinnedMeshRenderer deformingMesh;

    public void AddDeformingForce(Transform bone, float scale)
    {

        /// get bone position (both ends and middle)
        /// increase width/2 of ends points
        /// decrease width in middle
    }

    [ExecuteInEditMode]
    private void OnDrawGizmos()
    {
        foreach (Transform Bone in gameObject.GetComponentInChildren<SkinnedMeshRenderer>().bones)
        {

            Gizmos.color = Color.blue;
            Gizmos.DrawLine(Bone.GetChild(0).position, Bone.position);
            Gizmos.DrawLine(Bone.position, Bone.GetChild(0).position);
            Gizmos.color = Color.red;
            Gizmos.DrawCube(Bone.position, new Vector3(1f, 1f, 1f));

        }
    }
}
