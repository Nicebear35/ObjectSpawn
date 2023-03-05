using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int _health;
    private bool _isAlive;

    public int Health => _health;
    public bool IsAlive => _isAlive;
    private void Start()
    {
        _isAlive = true;
        _health = 5;
    }

    private void Update()
    {
        
    }

    public void EncreasingHelth()
    {
        _health++;
    }

    public void DecreasingHealth()
    {
        _health--;

        if(_health <= 0)
        {
            _isAlive = false;
        }
    }
}
