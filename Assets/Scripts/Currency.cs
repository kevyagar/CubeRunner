using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Currency : MonoBehaviour
{
    public int money;
    // Start is called before the first frame update
    void Start()
    {
        money = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void addMoney(int moneyAdded)
    {
        money += moneyAdded; 
    }
    public void subtractMoney(int moneySpent)
    {
        if (money - moneySpent < 0)
        {
            Debug.Log("You don't have enough money!");
        }
        else
            money -= moneySpent;
    }
}
