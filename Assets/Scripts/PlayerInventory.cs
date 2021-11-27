using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : Colleague
{
    private List<Item> _items = new List<Item>();

    // Start is called before the first frame update
    void Start()
    {
        _items.Add(new Item("Sword"));
        _items.Add(new Item("Shield"));
        _items.Add(new Item("Boots"));
    }

    public Item RemoveItem(Item item)
    {
        foreach (Item i in _items)
        {
            if(i.Equals(item))
            {
                _items.Remove(item);
                return item;
            }
        }

        return null;
    }

    public void Deposit()
    {
        if(_items.Count <= 0)
        {
            return;
        }
        else
        {
            mediator.Deposit(_items[0], this);
        }
    }
}
