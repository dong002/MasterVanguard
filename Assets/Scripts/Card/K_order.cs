using System.Collections.Generic;
using UnityEngine;

public class k_order : Card
{
    void Start()
    {
        cardName = "성재의 때, 도래했도다";

        power = 0;
        guard = 0;
        grade = 3;
        critical = 0;

        persona = false;
        intercept = false;
        boost = false;

        order = true;
        trigger = false;
        vanguard = false;
        drive = 0;
        stand = false;
    }

    public override void Use()
    {

        base.Use();
    }

}
