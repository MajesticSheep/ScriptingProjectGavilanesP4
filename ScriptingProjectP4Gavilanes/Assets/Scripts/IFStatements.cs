using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IFStatements : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    float coffeeTemperature = 85.0F;
    float hotLimittemperature = 70.0F;
    float coldLimitTemperature = 40.0F;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        coffeeTemperature -= Time.deltaTime * 5F;
    }
    void TemperatureTest()
    {
        //If the coffee's temperature is greater than the hottest drinking temperature...
        if(coffeeTemperature > hotLimittemperature)
        {
            //...do this.
            print("THE COFFEE'S TOO DANG HOT!!! IT BURNED MY FRICKING TOUNGE, AHHHHHHH!!!!!");
        }
        //If it isn't, but the coffee temperature is less than the coldest drinking temperature...
        else if(coffeeTemperature < coldLimitTemperature)
        {
            //...do this.
            print("THE COFFEE'S TOO DANG COLD >:("); 
        }
        //If it is neither of those then...
        else
        {
            //...do this.
            print("That's the stuff.");
        }
    }
}
