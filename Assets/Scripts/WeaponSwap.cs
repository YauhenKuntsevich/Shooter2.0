using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwap : MonoBehaviour
{
    [SerializeField] private GameObject[] weapons;

    private void Update()
    {
        SetWeapon(0);
        
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SetWeapon(0);
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
           SetWeapon(1);
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SetWeapon(2);
        }

    }

    private void SetWeapon(int weaponNumber)
    {
        for (int i = 1; i < weapons.Length; i++)
        {
            bool correctWeapon = (i == weaponNumber);

            var currentWeapon = weapons[i];

            if (correctWeapon)
            {
                currentWeapon.SetActive(true);
            }

            else
            {
                currentWeapon.SetActive(false);
            }
        }
    }
}
