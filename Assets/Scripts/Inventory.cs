using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Inventory // kho lưu trữ
{
    [System.Serializable]
    public class Slot
    {
        
        public CollectableType type;
        public int count;//biến cao sẽ theo dõi có bao nhiêu mục trong slot
        public int maxAllowed;//theo dõi mức tối đa

        public Slot()
        {
            type = CollectableType.NONE;
            count = 0;
            maxAllowed = 99;
        }
        public bool CanAddItem()
        {
            if(count < maxAllowed)
            {
                return true;
            }
            return false;
        }
        public void AddItem(CollectableType type)
        {
            this.type = type;
            count++;
        }

        
    }
    public List<Slot> slots = new List<Slot>();//tạo danh sách

    public Inventory(int numSlots)
    {
        for(int i = 0;i < numSlots; i++)
        {
            Slot slot = new Slot();
            slots.Add(slot);
        }
    }
    public void Add(CollectableType typeToAdd)
    {
        foreach(Slot slot in slots)
        {
            if (slot.type == typeToAdd && slot.CanAddItem())
            {
                slot.AddItem(typeToAdd);
                return;
            }
        }

        foreach(Slot slot in slots)
        {
            if (slot.type == CollectableType.NONE)
            {
                slot.AddItem(typeToAdd);
                return;
            }
        }
    }
}
