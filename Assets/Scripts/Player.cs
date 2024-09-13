using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //public int numCarrotSeed = 0;
    public Inventory inventory;
    private void Awake()
    {
        inventory = new Inventory(21);
    }
}
