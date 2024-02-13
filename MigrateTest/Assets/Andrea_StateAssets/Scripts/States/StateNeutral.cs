using System.Collections;
using UnityEngine;

public class StateNeutral : EmotionBaseState
{
    public IEnumerator coroutine;
    public override void EnterState(EmotionStateManager emotion){
        Debug.Log("Neutral!");
        //emotion.input.SetColor("_Input_Color_2", new Color(0,1,0,1));
        
        coroutine = emotion.ColorLerp(emotion.input.GetColor("_Input_Color_2"),Color.green,5f);
        emotion.StartCoroutine(coroutine);
    }

    public override void UpdateState(EmotionStateManager emotion){
        if(emotion.gameObject.transform.position.y > 1){
            emotion.StopCoroutine(coroutine);
            emotion.SwitchState(emotion.StateAngry);
        }

        if(emotion.gameObject.transform.position.y < -1){
            emotion.StopCoroutine(coroutine);
            emotion.SwitchState(emotion.StateSad);
        }
    }

    public override void onCollisionEnter(EmotionStateManager emotion, Collision collision){
        
    }
}
