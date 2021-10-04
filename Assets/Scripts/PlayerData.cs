using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData
{
    // Ordered list of the variables stored in the JSON file
    public string CharacterName = "";
    public string Alignment = "";

    public float Strength = 0;
    public float Dexterity = 0;
    public float Constitution = 0;
    public float Intelligence = 0;
    public float Wisdom = 0;
    public float Charisma = 0;

    public string Race = "";
    public string Class = "";

    public int ExpPoints = 0;
    public int MaxExpPoints = 0;
    public int HitPoints = 0;
    public int MaxHitPoints = 0;
    public int ArmorClass = 0;

    public int WalkingSpeed = 0;
    public int RunningSpeed = 0;
    public int JumpingHeight = 0;

    public List<string> ItemList;



}
