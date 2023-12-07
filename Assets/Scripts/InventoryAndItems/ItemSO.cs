using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ItemSO : ScriptableObject
{
    public string itemName;
    public StatToChange statToChange = new StatToChange();
    public int amountToChangeStat;

    public AttributeToChange attributeToChange = new AttributeToChange();
    public int amountToChangeAttribute;

    public void UseItem()
    {
        if(statToChange == StatToChange.health)
        {
            
        }
    }
    public enum StatToChange
    {
        None,
        health,
        food,
        water,
    };

    public enum AttributeToChange
    {
        none,
        strength,
        defense,
        intelligence,
        agility,
    };
}
