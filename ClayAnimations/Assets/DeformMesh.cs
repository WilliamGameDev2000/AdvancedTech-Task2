using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class DeformMesh : MonoBehaviour
{
    [SerializeField]MeshFilter deformingMesh;

    public void AddDeformingForce(GameObject bone, float scale)
    {
        Vector3 bone_startpos = bone.transform.position;
        Vector3 bone_endpos = bone.transform.position + new Vector3(0, 6, 0);

        Vector3 bone_middlepos = (bone_startpos + bone_endpos) / 2;

        //Debug.Log(bone_start);
        //Debug.Log(bone_end);
        //Debug.Log(bone_middle);
        bone.transform.localScale = new Vector3(1/scale, scale, 1/scale );



        deformingMesh.mesh.RecalculateBounds();
        
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
