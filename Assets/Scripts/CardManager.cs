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
    {
        deck.Add("뿡냥", new Card());
    }
}
