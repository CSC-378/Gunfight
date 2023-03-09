using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WeaponID
{
    AK47,
    Knife,
    Pistol,
    Sniper,
    Uzi
}

public class WeaponInfo : MonoBehaviour
{
    public WeaponID id;
    public int nAmmo;

    public float range;
    public float speedOfPlayer;
}