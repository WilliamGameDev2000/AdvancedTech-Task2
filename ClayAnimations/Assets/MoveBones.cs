using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBones : MonoBehaviour
{
    GameObject bone;
    GameObject player;

    [SerializeField] int bonePick;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("SimpleMan/Body");
        bone = player.GetComponent<SkinnedMeshRenderer>().bones[bonePick].gameObject;
        Debug.Log(bone);
    }

    // Update is called once per frame
    void Update()
    {
        bone.transform.localEulerAngles = new Vector3(bone.transform.eulerAngles.x + 0.02f * Time.deltaTime, bone.transform.eulerAngles.y + 0.02f * Time.deltaTime, bone.transform.eulerAngles.z + 0.02f * Time.deltaTime);
    }
}
