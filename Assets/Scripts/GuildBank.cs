using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuildBank : MonoBehaviour
{
    public List<Item> ItemsStored = new List<Item>();

    private int _storageSpace = 5;
    private int _freeSlots = 5;

    public int StorageSpace { get => _storageSpace; set => _storageSpace = value; }
    public int FreeSlots { get => _freeSlots; set => _freeSlots = value; }
}
