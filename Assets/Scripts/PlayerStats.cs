using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    [Header("Player Stats")]
    [SerializeField] int HealthBar = 100;
    [SerializeField] int WaterBar = 100;
    [SerializeField] int FoodBar = 100;

    [Header("Deduction")]
    int StatsDeduction = 1;
    int TimerInterval = 3;

    float timer = 0f;

    [Header("Text Box")]
    public Text Health;
    public Text Food;
    public Text Water;

    void Update()
    {
        Health.text = "Health: " + HealthBar;
        Food.text = "Food: " + FoodBar;
        Water.text = "Water: " + WaterBar;

        timer += Time.deltaTime;

        DeductNumber();
        Debug.Log(HealthBar);
    }

    void DeductNumber()
    {
        if (timer >= TimerInterval)
        {
            timer = 0;
            Debug.Log(FoodBar + " and " + WaterBar);

            FoodAndWaterDeduction();
        }
    }

    void FoodAndWaterDeduction()
    {
        // Deduct the specified amount from food and water
        FoodBar -= StatsDeduction;
        WaterBar -= StatsDeduction;

        // Ensure food and water don't go below zero
        FoodBar = Mathf.Max(FoodBar, 0);
        WaterBar = Mathf.Max(WaterBar, 0);

        HealthCheck();
    }

    void HealthCheck()
    {
        if (FoodBar <= 0 || WaterBar <= 0)
        {
         HealthBar -= 1;
        }
    }

    void Eating()
    {
        if (Input.GetKey(KeyCode.Mouse1) && gameObject.tag == "FoodItem")
        {
            // Incorporate Food stats from their own scripts
            //FoodBar = FoodBar += FoodItemStats;
        }
    }
}
