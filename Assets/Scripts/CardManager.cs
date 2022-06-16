using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : Singleton<CardManager>
{
    public List<GameObject> cards = new List<GameObject>();

    Dictionary<string, Card> deck = new Dictionary<string, Card>();

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DeckSetting()
    {//이름, 파워,가드,그레이드,드라이브,크리티컬,페르소나,부스트,인터셉트,오더,트리거,뱅가드,스탠드
        deck.Add("pot", new Card("천검의 기사 포트",8000,5000,1,1,1,false,true,false,false,false,false,true));
        deck.Add("base", new Card("베이스", 6000, 5000, 1, 1,1, false, true, false, false, false, true, true));
        deck.Add("asesu", new Card("아세스", 5000, 15000, 0,1,1,false,true,false,false,true,false,true));
        deck.Add("bastion", new Card("정점의 천재 바스티온", 13000,0,3,2,1,true,false,false,false,false,false,true));
        deck.Add("galruseu", new Card("갈루스", 5000, 5000, 0, 1, 1, false, true, false, false, true, false, true));
        deck.Add("rib", new Card("리브", 5000, 15000, 0, 1, 1, false, true, false, false, true, false, true));
        deck.Add("risana", new Card("리사나", 8000, 5000, 1, 1, 1, false, true, false, false, false, false, true));
        deck.Add("rokeuseu", new Card("루크스", 10000, 5000, 2, 1, 1, false, false, true, false, false, false, true));
        deck.Add("wolf", new Card("울프", 8000, 5000, 1, 1, 1, false, true, false, false, false, false, true));
        deck.Add("k-order", new Card("성재의 때, 도래했도다", 0, 0, 3, 0, 0, false, false, false, true, false, false, false));
        deck.Add("krabiel", new Card("구명천사 클라비엘", 7000, 0, 1, 1, 1, false, true, false, false, false, false, true));
        deck.Add("oreubaria", new Card("결의의 정령왕 오르바리아", 5000, 50000, 0, 1, 1, false, true, false, false, true, false, true));
        deck.Add("pot", new Card("천검의 기사 포트", 8000, 5000, 1, 1, 1, false, true, false, false, false, false, true));
        deck.Add("ramana", new Card("극심의 마녀 라마나", 13000, 0, 3, 2, 1, true, false, false, false, false, false, true));
        deck.Add("rapreukeu", new Card("부월의 기사 라프르크", 13000, 0, 3, 2, 1, true, false, false, false, false, false, true));
    }
    
    
}
