using UnityEngine;
using System.Collections;

public class BaseEquipment : BaseStatItem {
    public enum EquipmentTypes
    {
        HELMET,
        CHEST,
        LEGS,
        BOOTS,
        GUANLETS,
        NECK,
        EAR,
        CAPE,
        RING
    }
    private EquipmentTypes equipmentType;
    public EquipmentTypes EquipmentType
    {
        get { return equipmentType; }
        set { equipmentType = value; }
    }

}
