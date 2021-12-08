using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBones : MonoBehaviour
{
    GameObject bone;
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        bone = player.transform.Find("Armature/LowerlegTarget.L.001").gameObject;
        Debug.Log(bone);
    }

    // Update is called once per frame
    void Update()
    {
        bone.transform.localEulerAngles = new Vector3(bone.transform.eulerAngles.x + 2, bone.transform.eulerAngles.y + 2, bone.transform.eulerAngles.z + 2);
    }
}
