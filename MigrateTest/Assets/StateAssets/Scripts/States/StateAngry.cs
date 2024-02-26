using System.Collections;
using UnityEngine;

public class StateAngry : EmotionBaseState
{
    private IEnumerator coroutine;
    private float timerNeutral = 0.0f;

    public override void EnterState(EmotionStateManager emotion){
        Debug.Log("Angry!");
        timerNeutral = 0.0f;

        coroutine = emotion.ColorLerp(emotion.input.GetColor("_Input_Color_2"),new Color32(153,32,18,255),2f);
        emotion.StartCoroutine(coroutine);

        emotion.backg.SetAngry();
        emotion.soundManager.AngrySound();
    }

    public override void UpdateState(EmotionStateManager emotion){

        if(timerNeutral >= 4.0f){
            if(emotion.limbs.leftElbow.transform.position.x < emotion.limbs.leftHand.transform.position.x || emotion.limbs.rightElbow.transform.position.x > emotion.limbs.rightHand.transform.position.x)
            {
                emotion.StopCoroutine(coroutine);
                emotion.SwitchState(emotion.StateNeutral);
            }
        }
        else{
            timerNeutral += Time.deltaTime;
        }
    }

    public override void onCollisionEnter(EmotionStateManager emotion, Collision collision){
        
    }
}
