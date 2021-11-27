using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BankMediator : Mediator
{
    [SerializeField]
    private GuildBank _bank;

    public override bool Deposit(Item item, PlayerInventory player)
    {
        if(_bank.FreeSlots <= 0)
        {
            Debug.Log("Out of Space! can't deposit Item");
            return false;
        }
        else
        {
            Debug.Log("Depositing Item:" + item.ItemName);
            _bank.ItemsStored.Add(player.RemoveItem(item));
            _bank.FreeSlots--;
            return true;

        }
    }
}
