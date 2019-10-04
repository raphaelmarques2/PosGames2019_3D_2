using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimInput : MonoBehaviour
{

    PlayerAnimControl control;

    void Start()
    {
        control = GetComponent<PlayerAnimControl>();
    }
    
    void Update()
    {
        float h = Input.GetAxis("Vertical");

        control.walk = h > 0;

        float wantedSpeed = Input.GetKey(KeyCode.LeftShift) ? 1 : 0;
        control.speed = Mathf.MoveTowards(control.speed, wantedSpeed, 1f * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
            control.Jump();
    }
}
