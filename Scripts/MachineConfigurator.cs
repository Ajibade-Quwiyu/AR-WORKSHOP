using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MachineConfigurator : MonoBehaviour
{
    [SerializeField] private Slider rotator;
    [SerializeField] private Slider scaler;
    [SerializeField] private Toggle exploder;
    private Canvas rend;
    private Animator anim;



    private void Awake()
    {
        rend = GetComponentInChildren<Canvas>();
        anim = GetComponentInChildren<Animator>();
    }

    public void MachineRotate () 
    {
        transform.rotation = Quaternion.Euler(0, rotator.value, 0);
    }

    public void MachineScale()
    {
        transform.localScale = new Vector3(scaler.value, scaler.value, scaler.value);
    }
    public void OnObject()
    {
       
        if (rend.enabled)
            rend.enabled = false;
        else
            rend.enabled = true;
    }
    public void OnExplode()
    {
        if (!exploder.isOn)
        {
            anim.Play("in");
        }
        else
            anim.Play("out");
    }
   
}
