using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmotionStateManager : MonoBehaviour
{
    //Context to StateMachine

    public LimbViewer limbs;
    public Material input;
    EmotionBaseState currentState;
    public StateAngry StateAngry = new StateAngry();
    public StateHappy StateHappy = new StateHappy();
    public StateSad StateSad = new StateSad();
    public StateNeutral StateNeutral = new StateNeutral();

    void Start()
    {

        currentState = StateNeutral;

        currentState.EnterState(this);
    }

    void Update()
    {
        currentState.UpdateState(this);
    }

    void OnCollisionEnter(Collision collision){
        currentState.onCollisionEnter(this, collision);
    }

    public void SwitchState(EmotionBaseState state){
        currentState = state;
        state.EnterState(this);
    }

    public virtual IEnumerator ColorLerp(Color startColor, Color endColor, float conversionTime){
        float startTime = Time.time;
	    while (Time.time - startTime <= conversionTime) {
		    Color currentColor = Color.Lerp(startColor, endColor, Mathf.Clamp01((Time.time - startTime) / conversionTime));
        input.SetColor("_Input_Color_2", currentColor);
        yield return null;
        }
    }
}
