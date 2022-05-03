using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public string cardName;

    public int power;
    public int guard;
    public int grade;
    public int drive;
    public int critical;

    public bool persona;
    public bool boost;
    public bool intercept;
    public bool order;
    public bool trigger;
    public bool vanguard;
    public bool stand;

    public virtual void Use() { }

}
