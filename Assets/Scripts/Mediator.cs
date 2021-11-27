using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Mediator : MonoBehaviour
{
    public abstract bool Deposit(Item item, PlayerInventory player);
}