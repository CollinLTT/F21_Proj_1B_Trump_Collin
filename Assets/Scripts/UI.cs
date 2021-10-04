using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    //All variables to be used in menu
    public DataManager dataManager;

    public string charName;
    public string charAlignment;

    public int walkSpeed;
    public int runSpeed;
    public int jumpHeight;

    public int expPoints;
    public int maxExpPoints;
    public int hitPoints;
    public int maxHitPoints;
    public int armorClass;

    public string charRace;
    public string charClass;

    public float STR;
    public float DEX;
    public float CON;
    public float INT;
    public float WIS;
    public float CHA;



    // Start is called before the first frame update
    void Start()
    {
        //loads all the data from the text file
        dataManager.LoadData();

        //initializes inputs to file inputs
        charName = dataManager.data.CharacterName;
        charAlignment = dataManager.data.Alignment;

        walkSpeed = dataManager.data.WalkingSpeed;
        runSpeed = dataManager.data.RunningSpeed;
        jumpHeight = dataManager.data.JumpingHeight;

        expPoints = dataManager.data.ExpPoints;
        maxExpPoints = dataManager.data.MaxExpPoints;
        hitPoints = dataManager.data.HitPoints;
        maxHitPoints = dataManager.data.MaxHitPoints;
        armorClass = dataManager.data.ArmorClass;

        charRace = dataManager.data.Race;
        charClass = dataManager.data.Class;

        STR = dataManager.data.Strength;
        DEX = dataManager.data.Dexterity;
        CON = dataManager.data.Constitution;
        INT = dataManager.data.Intelligence;
        WIS = dataManager.data.Wisdom;
        CHA = dataManager.data.Charisma;

    }

    public void Callback_Char_Name(string name)
    {
        //sets the Character name in the file to user input
        dataManager.data.CharacterName = name;
    }

    public void Callback_Char_Alignment(string alignment)
    {
        //sets the Character Alignment in the file to user input
        dataManager.data.Alignment = alignment;
    }

    public void Callback_Set_Walking_Speed(float walkVal)
    {
        //sets the Character Walking Speed in the file to user input
        dataManager.data.WalkingSpeed = (int)walkVal;

    }

    public void Callback_Set_Running_Speed(float runVal)
    {
        dataManager.data.RunningSpeed = (int)runVal;

    }

    public void Callback_Set_Jump_Height(float jumpVal)
    {
        dataManager.data.JumpingHeight = (int)jumpVal;
    }

    public void Callback_Exp_Points(string exp)
    {
        dataManager.data.ExpPoints = int.Parse(exp);
    }

    public void Callback_Max_Exp_Points(string maxExp)
    {
        dataManager.data.MaxExpPoints = int.Parse(maxExp);
    }

    public void Callback_Hit_Points(string hp)
    {
        dataManager.data.HitPoints = int.Parse(hp);
    }

    public void Callback_Max_Hit_Points(string maxHp)
    {
        dataManager.data.MaxHitPoints = int.Parse(maxHp);
    }

    public void Callback_Armor_Class(string armClass)
    {
        //checks for positive integer from 1 to 100 from user input
        if (int.Parse(armClass) >= 1 && int.Parse(armClass) <= 100)
        {
            dataManager.data.ArmorClass = int.Parse(armClass);
        }
        else
            dataManager.data.ArmorClass = 0;
    }

    public void Callback_Race(int chRace)
    {
        if(chRace == 1)
        {
            dataManager.data.Race = "Dragonborn";
        }
        if (chRace == 2)
        {
            dataManager.data.Race = "Dwarf";
        }
        if (chRace == 3)
        {
            dataManager.data.Race = "Elf";
        }
        if (chRace == 4)
        {
            dataManager.data.Race = "Gnome";
        }
        if (chRace == 5)
        {
            dataManager.data.Race = "Half-Elf";
        }
        if (chRace == 6)
        {
            dataManager.data.Race = "Half-Orc";
        }
        if (chRace == 7)
        {
            dataManager.data.Race = "Halfling";
        }
        if (chRace == 8)
        {
            dataManager.data.Race = "Human";
        }
        if (chRace == 9)
        {
            dataManager.data.Race = "Tiefling";
        }

    }

    public void Callback_Class(int chClass)
    {

        if (chClass == 1)
        {
            dataManager.data.Class = "Barbarian";
        }
        if (chClass == 2)
        {
            dataManager.data.Class = "Bard";
        }
        if (chClass == 3)
        {
            dataManager.data.Class = "Cleric";
        }
        if (chClass == 4)
        {
            dataManager.data.Class = "Druid";
        }
        if (chClass == 5)
        {
            dataManager.data.Class = "Fighter";
        }
        if (chClass == 6)
        {
            dataManager.data.Class = "Monk";
        }
        if (chClass == 7)
        {
            dataManager.data.Class = "Paladin";
        }
        if (chClass == 8)
        {
            dataManager.data.Class = "Ranger";
        }
        if (chClass == 9)
        {
            dataManager.data.Class = "Rogue";
        }
        if (chClass == 10)
        {
            dataManager.data.Class = "Sorcerer";
        }
        if (chClass == 11)
        {
            dataManager.data.Class = "Warlock";
        }
        if (chClass == 12)
        {
            dataManager.data.Class = "Wizard";
        }
    }

    public void Callback_STR(string str)
    {
        dataManager.data.Strength = (float)int.Parse(str) + 2;
    }

    public void Callback_DEX(string dex)
    {
        dataManager.data.Dexterity = (float)int.Parse(dex) + 2;
    }

    public void Callback_CON(string con)
    {
        dataManager.data.Constitution = (float)int.Parse(con) + 2;
    }

    public void Callback_INT(string intel)
    {
        dataManager.data.Intelligence = (float)int.Parse(intel) + 2;
    }

    public void Callback_WIS(string wis)
    {
        dataManager.data.Wisdom = (float)int.Parse(wis) + 2;
    }

    public void Callback_CHA(string cha)
    {
        dataManager.data.Charisma = (float)int.Parse(cha) + 2;
    }

    public void Callback_Save()
    {
        //saves all the user input data into the file
        dataManager.SaveData();
    }


}
