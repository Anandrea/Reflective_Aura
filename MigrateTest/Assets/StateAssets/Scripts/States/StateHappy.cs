using System.Collections;
using UnityEngine;

public class StateHappy : EmotionBaseState
{
    private IEnumerator coroutine;
    private IEnumerator waiting;

    public override void EnterState(EmotionStateManager emotion){
        Debug.Log("Happy!");
        
        coroutine = emotion.ColorLerp(emotion.input.GetColor("_Input_Color_2"),Color.yellow,2f);
        waiting = emotion.WaitUntilStateChange();

        emotion.StartCoroutine(coroutine);
        emotion.StartCoroutine(waiting);
    }

    public override void UpdateState(EmotionStateManager emotion){
        /*if(emotion.gameObject.transform.position.y < 1){
            emotion.StopCoroutine(coroutine);
            emotion.SwitchState(emotion.StateAngry);
        }*/

        if(emotion.waited = true){
            //hier dann die Bedingung, die dann nicht mehr erfüllt ist um in den StateAngry zu kommen
                //emotion.waited = false;
                //emotion.StopCoroutine(coroutine);
                //emotion.SwitchState(emotion.StateNeutral);
        }
    }

    public override void onCollisionEnter(EmotionStateManager emotion, Collision collision){
        
    }
}
