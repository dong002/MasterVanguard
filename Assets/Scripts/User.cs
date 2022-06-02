using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class User : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
         cardName = "천궁의 기사 베이스";

        power = 6000;
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

    // Update is called once per frame
    void Update()
    {
        
    }
}
