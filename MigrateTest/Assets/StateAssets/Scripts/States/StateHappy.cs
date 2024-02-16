using System.Collections;
using UnityEngine;

public class StateHappy : EmotionBaseState
{
    private IEnumerator coroutine;
    private float timerNeutral = 0.0f;

    public override void EnterState(EmotionStateManager emotion){
        Debug.Log("Happy!");
        timerNeutral = 0.0f;
        
        coroutine = emotion.ColorLerp(emotion.input.GetColor("_Input_Color_2"),Color.yellow,2f);
        emotion.StartCoroutine(coroutine);
    }

    public override void UpdateState(EmotionStateManager emotion){

        /*if(timerNeutral >= 4.0f){
            if(){
                emotion.StopCoroutine(coroutine);
                emotion.SwitchState(emotion.StateNeutral);
            }
        }
        else{
            timerNeutral += Time.deltaTime;
        }*/
    }

    public override void onCollisionEnter(EmotionStateManager emotion, Collision collision){
        
    }
}
