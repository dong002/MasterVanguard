using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testCard : Card
{
    void Start() {
        cardName = "정점의 천재 바스티온";
        power = 13000;
        guard = 0;
        grade = 3;
        order = false;
        trigger = false;
        vanguard = true;
    }

    public override void Use()
    {
        if (vanguard == true)
        {

        }
        base.Use();
    }
}
