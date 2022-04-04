using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
public class DeformMesh : MonoBehaviour
{
    Mesh deformingMesh;
    Vector3[] originalVerts, displacedVerts;
    Vector3[] vertexVelocities;

    //[SerializeField] float force = 10f;

    private void Start()
    {
        deformingMesh = GetComponent<MeshFilter>().mesh;
        originalVerts = deformingMesh.vertices;
        displacedVerts = new Vector3[originalVerts.Length];

        for (int i = 0; i < originalVerts.Length; i++)
        {
            displacedVerts[i] = originalVerts[i];
        }

        vertexVelocities = new Vector3[originalVerts.Length];
    }

    public void AddDeformingForce()
    {
        for (int i = 0; i < displacedVerts.Length; i++)
        {
            UpdateVerts(i);
        }
        deformingMesh.vertices = displacedVerts;
        deformingMesh.RecalculateNormals();
        //take area based on weight painting? (Unless moving bones scales bones earlier in chain)
    }

    void UpdateVerts(int i)
    {
        Vector3 velocity = vertexVelocities[i];
        displacedVerts[i] += velocity * Time.deltaTime;
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
