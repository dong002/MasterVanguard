using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public string cardName;
    public int power;
    public int guard;
    public int grade;
    public bool order;
    public bool trigger;
    public bool vanguard;

    public virtual void Use() { }

}
