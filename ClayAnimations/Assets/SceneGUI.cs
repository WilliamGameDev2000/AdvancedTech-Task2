using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneGUI : MonoBehaviour
{
    GameObject clay;
    Transform[] bone_collection;
    [SerializeField] Text currentBoneText;

    DeformMesh deform;
    [SerializeField] Select[] _selected;

    int selected_bone = 0;
    void LateUpdate()
    {
        foreach (Select item in _selected)
        {
            if (item.GetSelected())
            {
                clay = item.gameObject;
                bone_collection = clay.GetComponentInChildren<SkinnedMeshRenderer>().bones;
                deform = clay.GetComponent<DeformMesh>();
                currentBoneText.text = selected_bone.ToString();
            }
        }

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100))
            {
                foreach (Select item in _selected)
                {
                    if (item.GetComponent<DeformMesh>() != null)
                    {
                        if (hit.transform.gameObject == item.gameObject)
                        {
                            item.SetSelected(true);
                        }
                        else
                        {
                            item.SetSelected(false);
                        }
                    }
                }
            }
        }
    }

    public void IncreaseBoneSelect()
    {
        selected_bone++;

        if (selected_bone >= bone_collection.Length)
        {
            selected_bone = 0;
        }
        currentBoneText.text = selected_bone.ToString();
    }

    public void DecreaseBoneSelect()
    {
        selected_bone--;

        if (selected_bone <= 0)
        {
            selected_bone = bone_collection.Length - 1;
        }
        currentBoneText.text = selected_bone.ToString();
    }

    public void CompactModelButton()
    {
        if (bone_collection[selected_bone].position.y > 10 || selected_bone == 0)
        {
            bone_collection[selected_bone].position = new Vector3(bone_collection[selected_bone].position.x, bone_collection[selected_bone].position.y - 10, bone_collection[selected_bone].position.z);
        }

    }

    public void StretchModelButton()
    {
        if (deform == null)
        {
            return;
        }

        //bone_collection[selected_bone].localScale = new Vector3(bone_collection[selected_bone].localScale.x, bone_collection[selected_bone].localScale.y + 1, bone_collection[selected_bone].localScale.z);
        deform.AddDeformingForce(bone_collection[selected_bone], 2);
    }
}
