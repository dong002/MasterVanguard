using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    public List<GameObject> cards = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        GameObject ca = cards[0];
        Debug.Log(ca.GetComponent<Card>().cardName);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
