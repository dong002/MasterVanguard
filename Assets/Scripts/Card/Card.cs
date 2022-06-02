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


    public Card(string _cardname, int _power, int _guard, int _drive, int _critical, bool _persona, bool _boost, bool _intercept, bool _order,
        bool _trigger, bool _vanguard, bool _stand)
    {
        this.cardName = _cardname;
        this.power = _power;
        this.guard = _guard;
        this.
    }
}
