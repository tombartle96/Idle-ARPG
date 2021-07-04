using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbilitySlot : MonoBehaviour
{
    public AbilityBase slottedAbility;
    private float cooldownTimer = 0f;
    public Image cooldownMask;
    
    private void Update()
    {
        if (cooldownTimer > 0)
        {
            cooldownTimer -= Time.deltaTime;
            cooldownMask.fillAmount = cooldownTimer / slottedAbility.cooldownTime;
        }
    }

    public void Use()
    {
        if (cooldownTimer <= 0)
        {
            slottedAbility.Activate();
            cooldownTimer = slottedAbility.cooldownTime;
        }
    }
}
