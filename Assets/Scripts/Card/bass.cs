using System.Collections.Generic;
using UnityEngine;

public class bass : Card
{
    void Start()
    {
        cardName = "천궁의 기사 베이스";

        power = 6000;
        guard = 5000;
        grade = 0;
        critical = 1;

        persona = false;
        intercept = false;
        boost = true;

        order = false;
        trigger = false;
        vanguard = true;
        drive = 1;
        stand = true;
    }

    public override void Use()
    {

        base.Use();
    }
}
