using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.UI;

public class MyAds : MonoBehaviour
{
    public Text textResult;
    
    public void ShowAds()
    {
        ShowAds("video");
    }
    public void ShowRewardedAds()
    {
        ShowAds("rewardedVideo");
    }

    void ShowAds(string id)
    {
        
        if (Advertisement.IsReady())
        {
            var options = new ShowOptions()
            {
                resultCallback = (result) => {
                    textResult.text = "result=" + result;
                }
            };
            
            Advertisement.Show(id, options);
        }
        else
        {
            textResult.text = "Not ready";
        }

    }

}
