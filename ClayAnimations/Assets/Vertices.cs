using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vertices : MonoBehaviour
{
    public float areaRadius;
    public float raisePower;

    public void PaintRaise(Vector3 center, float radius, float power)
    {
        Vector3 localPoint = transform.InverseTransformPoint(center);
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        List<Vector3> verts = new List<Vector3>();
        mesh.GetVertices(verts);


        for (int i = 0; i < verts.Count; ++i)
        {
            var heading = verts[i] - center;
            var distance = heading.magnitude;
            var direction = heading / distance;
            if (heading.sqrMagnitude > radius * radius)
            {
                verts[i] = new Vector3(
                    verts[i].x,
                    verts[i].y + power,
                    verts[i].z);
            }
        }
        mesh.SetVertices(verts);
    }

    public void PaintLower(Vector3 center, float radius, float power)
    {
        Vector3 localPoint = transform.InverseTransformPoint(center);
        Mesh mesh = this.gameObject.GetComponent<MeshFilter>().mesh;
        List<Vector3> verts = new List<Vector3>();
        mesh.GetVertices(verts);

        for (int i = 0; i < verts.Count; ++i)
        {
            var heading = verts[i] - center;
            var distance = heading.magnitude;
            var direction = heading / distance;
            if (heading.sqrMagnitude > radius * radius)
            {
                verts[i] = new Vector3(
                    verts[i].x,
                    verts[i].y - power,
                    verts[i].z);
            }
        }
        mesh.SetVertices(verts);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            
            PaintRaise(Input.mousePosition, areaRadius, raisePower);
        }
        if(Input.GetMouseButtonDown(1))
        {
            PaintLower(Input.mousePosition, areaRadius, raisePower);
        }
    }
}
