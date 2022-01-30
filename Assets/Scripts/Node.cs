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
        canBeUnlocked = GetCanBeUnlocked();
    }

    bool GetCanBeUnlocked()
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

    public void TryUnlock()
    {
        if (GetCanBeUnlocked())
        {
            locked = false;
            Debug.Log("I am the " + name + " node and I am unlocked now");
        }
        else
        {
            Debug.Log("I am the " + name + " node and my requirements have to be unlocked first");
        }
    }
}
