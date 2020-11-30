using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineController : MonoBehaviour
{
    public GameObject[] Machines;

    private void Start()
    {
        ShowObject(0);
    }

    public void ShowObject(int Obj)
    {
        int Count = Machines.Length;

        if (Obj <= Count)
        {
            for(int i = 1; i < Count+1; i++)
            {
                if (Obj == i)
                {
                    Machines[i - 1].SetActive(true);
                }
                else
                {
                    Machines[i - 1].SetActive(false);
                }
            }
        }
    }
     
}
