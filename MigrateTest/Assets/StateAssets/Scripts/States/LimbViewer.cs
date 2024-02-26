using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimbViewer : MonoBehaviour
{
    GameObject trackingArea;
    public GameObject leftHand;
    public GameObject rightHand;

    public GameObject leftElbow;
    public GameObject rightElbow;

    public GameObject head;
    public GameObject spine;

    void Start(){
        trackingArea = GameObject.Find("TrackingArea");
    }

    void Update(){
        
        if(GameObject.Find("CapturyAvatar(Clone)/defaultLiveHands/Root/Hips/Spine/Spine1/Spine2/Spine3/LeftShoulder/LeftArm/LeftForeArm/LeftHand")){
            leftHand = GameObject.Find("CapturyAvatar(Clone)/defaultLiveHands/Root/Hips/Spine/Spine1/Spine2/Spine3/LeftShoulder/LeftArm/LeftForeArm/LeftHand");
        }
        else{
            Debug.Log("leftHand doesn't exist!");
        }

        if(GameObject.Find("CapturyAvatar(Clone)/defaultLiveHands/Root/Hips/Spine/Spine1/Spine2/Spine3/RightShoulder/RightArm/RightForeArm/RightHand")){
            rightHand = GameObject.Find("CapturyAvatar(Clone)/defaultLiveHands/Root/Hips/Spine/Spine1/Spine2/Spine3/RightShoulder/RightArm/RightForeArm/RightHand");
        }
        else{
            Debug.Log("rightHand doesn't exist!");
        }

        if(GameObject.Find("CapturyAvatar(Clone)/defaultLiveHands/Root/Hips/Spine/Spine1/Spine2/Spine3/Spine4/Neck/Head/HeadEE")){
            head = GameObject.Find("CapturyAvatar(Clone)/defaultLiveHands/Root/Hips/Spine/Spine1/Spine2/Spine3/Spine4/Neck/Head/HeadEE");
        }
        else{
            Debug.Log("head doesn't exist!");
        }

        if (GameObject.Find("CapturyAvatar(Clone)/defaultLiveHands/Root/Hips/Spine/Spine1/Spine2/Spine3/Spine4"))
        {
            spine = GameObject.Find("CapturyAvatar(Clone)/defaultLiveHands/Root/Hips/Spine/Spine1/Spine2/Spine3/Spine4");
        }
        else
        {
            Debug.Log("spine doesn't exist!");
        }

        if (GameObject.Find("CapturyAvatar(Clone)/defaultLiveHands/Root/Hips/Spine/Spine1/Spine2/Spine3/LeftShoulder/LeftArm/LeftForeArm"))
        {
            leftElbow = GameObject.Find("CapturyAvatar(Clone)/defaultLiveHands/Root/Hips/Spine/Spine1/Spine2/Spine3/LeftShoulder/LeftArm/LeftForeArm");
        }
        else
        {
            Debug.Log("leftElbow doesn't exist!");
        }

        if (GameObject.Find("CapturyAvatar(Clone)/defaultLiveHands/Root/Hips/Spine/Spine1/Spine2/Spine3/RightShoulder/RightArm/RightForeArm"))
        {
            rightElbow = GameObject.Find("CapturyAvatar(Clone)/defaultLiveHands/Root/Hips/Spine/Spine1/Spine2/Spine3/RightShoulder/RightArm/RightForeArm");
        }
        else
        {
            Debug.Log("rightElbow doesn't exist!");
        }
    }
}
