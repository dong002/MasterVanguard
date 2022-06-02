using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pot : Card
{
    void Start()
    {
        cardName = "천검의 기사 포트";

        power = 8000;
        guard = 5000;
        grade = 1;
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
