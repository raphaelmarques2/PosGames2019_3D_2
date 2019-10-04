using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitch : MonoBehaviour
{
    CinemachineMixingCamera mixin;

    void Start()
    {
        mixin = GetComponent<CinemachineMixingCamera>();
    }

    //0 = rear   1 = shoulder
    private float shoulderValue;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            StopAllCoroutines();
            StartCoroutine(MoveCamTo(0));
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            StopAllCoroutines();
            StartCoroutine(MoveCamTo(1));
        }
    }
    
    IEnumerator MoveCamTo(float wanted)
    {
        while (shoulderValue != wanted)
        {
            shoulderValue = Mathf.MoveTowards(shoulderValue, wanted, 2 * Time.deltaTime);

            mixin.SetWeight(0, 1f - shoulderValue);//rear
            mixin.SetWeight(1, shoulderValue);//shoulder

            yield return null;
        }
    }
}
