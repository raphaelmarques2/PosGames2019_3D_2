using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    public Material matOff;
    public Material matOn;
    
    MeshRenderer render;

    private void OnEnable()
    {
        render = GetComponent<MeshRenderer>();
        
        //cria uma cor aleatoria 
        var color = Color.HSVToRGB(Random.value, 1, 1);
        color.a = 0.5f;

        //duplica o material pra mudar a cor
        matOn = Instantiate(matOn);
        matOn.color = color;
        
        SetMaterial(false);
    }

    void SetMaterial(bool value)
    {
        render.material = value ? matOn : matOff;
    }

    private void OnTriggerEnter(Collider other)
    {
        SetMaterial(true);
    }
    private void OnTriggerExit(Collider other)
    {
        SetMaterial(false);
    }
}
