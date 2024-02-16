using System.Collections;
using UnityEngine;

public class StateNeutral : EmotionBaseState
{
    public IEnumerator coroutine;
    float timerAngry = 0.0f;
    float timerSad = 0.0f;
    float timerHappy = 0.0f;

    public override void EnterState(EmotionStateManager emotion){
        Debug.Log("Neutral!");
        
        coroutine = emotion.ColorLerp(emotion.input.GetColor("_Input_Color_2"),Color.green,2f);
        emotion.StartCoroutine(coroutine);
    }

    public override void UpdateState(EmotionStateManager emotion){

        //hier sollen die ganzen timerabfragen für jeden state kommen

        if(emotion.limbs.head && emotion.limbs.leftHand && emotion.limbs.rightHand != null){
            Debug.Log("First if");

            if(emotion.limbs.leftHand.transform.position.y > emotion.limbs.rightHand.transform.position.y){
                Debug.Log("Second if");
                emotion.StopCoroutine(coroutine);
                emotion.SwitchState(emotion.StateAngry);
            }
        }
    }

    public override void onCollisionEnter(EmotionStateManager emotion, Collision collision){
        
    }
}
