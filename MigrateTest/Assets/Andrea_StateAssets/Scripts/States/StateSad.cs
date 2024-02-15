using System.Collections;
using UnityEngine;

public class StateSad : EmotionBaseState
{
    private IEnumerator coroutine;

    public override void EnterState(EmotionStateManager emotion){
        Debug.Log("Sad!");
        //emotion.input.SetColor("_Input_Color_2", new Color(0,0,1,1));
        
        coroutine = emotion.ColorLerp(emotion.input.GetColor("_Input_Color_2"),Color.blue,2f);
        emotion.StartCoroutine(coroutine);
    }

    public override void UpdateState(EmotionStateManager emotion){
        /*if(emotion.gameObject.transform.position.y > 0){
            emotion.StopCoroutine(coroutine);
            emotion.SwitchState(emotion.StateNeutral);
        }*/
    }

    public override void onCollisionEnter(EmotionStateManager emotion, Collision collision){
        
    }
}
