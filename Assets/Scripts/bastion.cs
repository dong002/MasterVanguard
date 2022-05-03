using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bastion : Card
{
    void Start() {
        cardName = "정점의 천제 바스티온";

        power = 13000;
        guard = 0;
        grade = 3;
        critical = 1;

        persona = true;
        intercept = false;
        boost = false;

        order = false;
        trigger = false;
        vanguard = true;
        drive = 2;
        stand = true;
    }

    public override void Use()
    {
        if (vanguard == true)
        {
            for(int i = 0; i<5; i++)
            {
                Card card = CardManager.Instance.cards[i].GetComponent<Card>();

                if (card.grade == 3)
                {
                    card.power += 2000;
                }
                
            }

        }

        // if (driveCount == 3) {
        //   Card card = CardManager.Instance.cards[n].GetComponent<Card>();
        //   card.stand == True;
        base.Use();
    }
}
