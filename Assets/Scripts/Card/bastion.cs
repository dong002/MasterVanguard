using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bastion : Card
{
    

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
