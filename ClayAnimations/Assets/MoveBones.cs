using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MoveBones : MonoBehaviour
{
    GameObject bone;
    GameObject player;

   

    //[SerializeField] [Range(0, 16)]int bonePick;
    // Start is called before the first frame update
    void Awake()
    {
        player = GameObject.Find("SimpleMan/Body");

            //setBone(bonePick);
    }
    // Update is called once per frame
    void Update()
    {
        //setBone(bonePick);
        //bone.transform.localEulerAngles = new Vector3(bone.transform.eulerAngles.x + 0.02f * Time.deltaTime, bone.transform.eulerAngles.y + 0.02f * Time.deltaTime, bone.transform.eulerAngles.z + 0.02f * Time.deltaTime);
    }

  /*  public void setBone(int bonepicked)
    {
        bonePick = bonepicked;
        bone = player.GetComponent<SkinnedMeshRenderer>().bones[bonePick].gameObject;
    }*/

    /*[ExecuteInEditMode]
    void OnDrawGizmosSelected()
    {
        Handles.color = Color.red;
        foreach(Transform Bone in player.GetComponent<SkinnedMeshRenderer>().bones)
        {
            if (Bone.parent != player.GetComponent<SkinnedMeshRenderer>().bones[0])
            {
                Handles.DrawLine(Bone.position, Bone.parent.position);
            }
            else
            {
                Handles.DrawLine(Bone.GetChild(0).position, Bone.position);
            }
        }

        Handles.color = Color.green;
        if(bonePick != 0)
        {
            Handles.DrawLine(bone.transform.position, bone.transform.parent.position);
        }
        else
        {
            Handles.DrawLine(bone.transform.GetChild(0).position, bone.transform.position);
        }
    }*/
}
