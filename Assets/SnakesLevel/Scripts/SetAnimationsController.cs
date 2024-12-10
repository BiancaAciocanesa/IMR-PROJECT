using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetAnimationsController : MonoBehaviour
{
    public Animator animator;

    public void SetHoldingState(bool holdingState)
    {
        animator.SetBool("isHolding", holdingState);
    }

    public void SetTriggerState(bool triggerState)
    {
        animator.SetBool("isTrigger", triggerState);
    }
}
