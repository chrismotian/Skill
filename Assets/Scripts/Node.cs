using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    [SerializeField] string name;
    bool locked = true;
    bool canBeUnlocked;
    [SerializeField] Node[] requirements = new Node[0];

    private void OnValidate()
    {
        canBeUnlocked = getCanBeUnlocked();
    }

    bool getCanBeUnlocked()
    {
        if(locked == false)
        {
            return false;
        }
        else
        {
            foreach(Node requirement in requirements) 
            {
                if (requirement.locked == true) return false;
            }
            return true;
        }
    }
}
