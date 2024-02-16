using System.Collections;
using UnityEngine;

public class StateNeutral : EmotionBaseState
{
    public IEnumerator coroutine;
    private float timerAngry = 0.0f;
    private float timerSad = 0.0f;
    private float timerHappy = 0.0f;

    public override void EnterState(EmotionStateManager emotion){
        Debug.Log("Neutral!");
        timerAngry = 0.0f;
        coroutine = emotion.ColorLerp(emotion.input.GetColor("_Input_Color_2"),Color.green,2f);
        emotion.StartCoroutine(coroutine);
    }

    public override void UpdateState(EmotionStateManager emotion){

        //hier sollen die ganzen timerabfragen für jeden state kommen
        if(emotion.limbs.head && emotion.limbs.leftHand && emotion.limbs.rightHand != null){

            if(emotion.limbs.leftHand.transform.position.y > emotion.limbs.rightHand.transform.position.y){
                timerAngry += Time.deltaTime;
                if(timerAngry >= 0.5f){ //hieranpassenjenachFunktionalität
                    Debug.Log("Timer erreicht");
                    emotion.StopCoroutine(coroutine);
                    emotion.SwitchState(emotion.StateAngry);  
                }
            }
        }

        /*if(BedingungSad){
            timerSad += Time.deltaTime;
            if(timerSad >= 3.0f){
                timerSad = 0.0f;
                emotion.StopCoroutine(coroutine);
                emotion.SwitchState(emotion.StateSad);

        if(BedingungHappy){
            timerHappy += Time.deltaTime;
            if(timerHappy >= 3.0f){
                timerHappy = 0.0f;
                emotion.StopCoroutine(coroutine);
                emotion.SwitchState(emotion.StateHappy);  
        


        if(emotion.limbs.head && emotion.limbs.leftHand && emotion.limbs.rightHand != null){
            Debug.Log("First if");

            if(emotion.limbs.leftHand.transform.position.y > emotion.limbs.rightHand.transform.position.y){
                Debug.Log("Second if");
                emotion.StopCoroutine(coroutine);
                emotion.SwitchState(emotion.StateAngry);
            }
        }*/
    }

    public override void onCollisionEnter(EmotionStateManager emotion, Collision collision){
        
    }
}
