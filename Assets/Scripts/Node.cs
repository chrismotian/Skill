using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    [SerializeField] string name;
    bool locked = true;
    bool canBeUnlocked;
}
