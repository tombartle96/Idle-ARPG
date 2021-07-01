using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimDirection : MonoBehaviour
{
    private Animator anim;
    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        Vector3 mousePos = Input.mousePosition;
        Vector3 screenCentre = new Vector3(Screen.width / 2f, Screen.height / 2f, 0f);
        
        Vector3 direction = (mousePos - screenCentre).normalized;
        
        // AimX and AimY should always be a whole number to prevent morphed animations
        float aimX = Mathf.RoundToInt(direction.x);
        float aimY = Mathf.RoundToInt(direction.y);
        
        anim.SetFloat("AimX", aimX);
        anim.SetFloat("AimY", aimY);
    }
}
