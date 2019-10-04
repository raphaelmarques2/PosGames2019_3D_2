using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneGrid : MonoBehaviour
{
    public GameObject original;

    public int width = 20;
    public int height = 20;
    
    void Start()
    {
        for (int i = -width/2; i <= width/2; i++)
        {
            for (int j = -height/2; j <= height/2; j++)
            {
                var localPos = new Vector3(i, 0, j);
                var pos = this.transform.TransformPoint(localPos);
                Instantiate(original, pos, Quaternion.identity, this.transform);
            }
        }
        original.SetActive(false);
    }
    
}
