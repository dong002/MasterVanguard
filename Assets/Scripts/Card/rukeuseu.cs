using System.Collections.Generic;
using UnityEngine;

public class rukeuseu : Card
{
    void Start()
    {
        cardName = "천창의 기사 룩스";

        power = 10000;
        guard = 5000;
        grade = 2;
        critical = 1;

        persona = false;
        intercept = true;
        boost = false;

        order = false;
        trigger = false;
        vanguard = true;
        drive = 1;
        stand = true;
    }

    public override void Use()
    {
        int count = 0;
        for (int i = 0; i<5; i++)
        {
            Card card = CardManager.Instance.cards[i].GetComponent<Card>();
            if(card.grade == 3)
            {
                count = count ++ ;

            }
        }

        if (count <= 3)
        {
            power += 5000;
            boost = true;
        }

        base.Use();
    }
}
