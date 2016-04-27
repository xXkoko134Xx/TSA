using UnityEngine;
using System.Collections;

public class BaseItem {
    public string itemName { get; set; }
    public string itemDes { get; set; }
    public int ItemId { get; set; }
    public enum ItemTypes
    {
        EQUIPMENT,
        WEAPON,
        SCROLL,
        POTION,
        CHEST
    }
    private ItemTypes itemTypes;

    public ItemTypes ItemType
    {
        get { return itemTypes; }
        set { itemTypes = value; }
    }
}
