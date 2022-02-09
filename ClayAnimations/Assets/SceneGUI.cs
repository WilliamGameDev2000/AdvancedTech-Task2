using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneGUI : MonoBehaviour
{
    [SerializeField] GameObject clay;
    Transform[] bone_collection;
    void Awake()
    {
        bone_collection = clay.GetComponentInChildren<SkinnedMeshRenderer>().bones;
    }

    public void CompactModelButton()
    {
        if(bone_collection[2].position.y > 10)
        {
            bone_collection[2].position = new Vector3(bone_collection[2].position.x, bone_collection[2].position.y - 10, bone_collection[2].position.z);
        }
        
    }

    public void StretchModelButton()
    {
        bone_collection[2].position = new Vector3(bone_collection[2].position.x, bone_collection[2].position.y + 10, bone_collection[2].position.z);
    }
}
