using System.Collections.Generic;
using UnityEngine;

public class Rukeuseu : Card
{


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
