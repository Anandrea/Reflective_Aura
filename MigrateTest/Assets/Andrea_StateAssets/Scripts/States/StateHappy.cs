using System.Collections;
using UnityEngine;

public class StateHappy : EmotionBaseState
{
    private IEnumerator coroutine;

    public override void EnterState(EmotionStateManager emotion){
        Debug.Log("Happy!");
        //emotion.input.SetColor("_Input_Color_2", new Color(1,1,0,1));
        
        coroutine = emotion.ColorLerp(emotion.input.GetColor("_Input_Color_2"),Color.yellow,5f);
        emotion.StartCoroutine(coroutine);
    }

    public override void UpdateState(EmotionStateManager emotion){
        if(emotion.gameObject.transform.position.y < 1){
            emotion.StopCoroutine(coroutine);
            emotion.SwitchState(emotion.StateAngry);
        }
    }

    public override void onCollisionEnter(EmotionStateManager emotion, Collision collision){
        
    }
}
