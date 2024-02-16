using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimbViewer : MonoBehaviour
{
    GameObject trackingArea;
    public GameObject leftHand;
    public GameObject rightHand;
    public GameObject head;

    void Start(){
        trackingArea = GameObject.Find("TrackingArea");
    }

    void Update(){
        
        if(GameObject.Find("defaultLiveHands(Clone)/Root/Hips/Spine/Spine1/Spine2/Spine3/LeftShoulder/LeftArm/LeftForeArm/LeftHand")){
            leftHand = GameObject.Find("defaultLiveHands(Clone)/Root/Hips/Spine/Spine1/Spine2/Spine3/LeftShoulder/LeftArm/LeftForeArm/LeftHand");
        }
        else{
            Debug.Log("leftHand doesn't exist!");
        }

        if(GameObject.Find("defaultLiveHands(Clone)/Root/Hips/Spine/Spine1/Spine2/Spine3/RightShoulder/RightArm/RightForeArm/RightHand")){
            rightHand = GameObject.Find("defaultLiveHands(Clone)/Root/Hips/Spine/Spine1/Spine2/Spine3/RightShoulder/RightArm/RightForeArm/RightHand");
        }
        else{
            Debug.Log("rightHand doesn't exist!");
        }

        if(GameObject.Find("defaultLiveHands(Clone)/Root/Hips/Spine/Spine1/Spine2/Spine3/Spine4/Neck/Head/HeadEE")){
            head = GameObject.Find("defaultLiveHands(Clone)/Root/Hips/Spine/Spine1/Spine2/Spine3/Spine4/Neck/Head/HeadEE");
        }
        else{
            Debug.Log("head doesn't exist!");
        }
    }
}
