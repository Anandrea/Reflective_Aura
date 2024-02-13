using System.Collections;
using UnityEngine;

public class StateAngry : EmotionBaseState
{
    private IEnumerator coroutine;

    public override void EnterState(EmotionStateManager emotion){
        Debug.Log("Angry!");
        //emotion.input.SetColor("_Input_Color_2", new Color(1,0,0,1));

        coroutine = emotion.ColorLerp(emotion.input.GetColor("_Input_Color_2"),Color.red,5f);
        emotion.StartCoroutine(coroutine);
    }

    public override void UpdateState(EmotionStateManager emotion){
        if(emotion.gameObject.transform.position.y > 2){
            emotion.StopCoroutine(coroutine);
            emotion.SwitchState(emotion.StateHappy);
        }

        if(emotion.gameObject.transform.position.y < 0){
            emotion.StopCoroutine(coroutine);
            emotion.SwitchState(emotion.StateNeutral);
        }
    }

    public override void onCollisionEnter(EmotionStateManager emotion, Collision collision){
        
    }
}
