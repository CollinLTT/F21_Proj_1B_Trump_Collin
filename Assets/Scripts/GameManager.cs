using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //all variables to be updated
    public Text WalkSpeed_Output;
    public Text RunSpeed_Output;
    public Text JumpHeight_Output;

    public Text eraseSTR;
    public Text eraseDEX;
    public Text eraseCON;
    public Text eraseINT;
    public Text eraseWIS;
    public Text eraseCHA;

    public InputField STR;
    public InputField DEX;
    public InputField CON;
    public InputField INT;
    public InputField WIS;
    public InputField CHA;

    // Start is called before the first frame update
    void Start()
    {
      
        //Finds the output text for each slider
        WalkSpeed_Output = GameObject.Find("WalkingSpeed_Output").GetComponent<Text>();
        RunSpeed_Output = GameObject.Find("RunSpeed_Output").GetComponent<Text>();
        JumpHeight_Output = GameObject.Find("JumpHeight_Output").GetComponent<Text>();

        //finds the placeholder text for each ability input field
        eraseSTR = GameObject.Find("strPlace").GetComponent<Text>();
        eraseDEX = GameObject.Find("dexPlace").GetComponent<Text>();
        eraseCON = GameObject.Find("conPlace").GetComponent<Text>();
        eraseINT = GameObject.Find("intPlace").GetComponent<Text>();
        eraseWIS = GameObject.Find("wisPlace").GetComponent<Text>();
        eraseCHA = GameObject.Find("chaPlace").GetComponent<Text>();

        //finds each ability input field
        STR = GameObject.Find("Strength").GetComponent<InputField>();
        DEX = GameObject.Find("Dexterity").GetComponent<InputField>();
        CON = GameObject.Find("Constitution").GetComponent<InputField>();
        INT = GameObject.Find("Intelligence").GetComponent<InputField>();
        WIS = GameObject.Find("Wisdom").GetComponent<InputField>();
        CHA = GameObject.Find("Charisma").GetComponent<InputField>();

    }



    //Returns 3 highest rolls on 8 sided die
    private int Roll()
    {
        List<int> diceRolls = new List<int>();

        //rolls 5 times between 1 and 8
        for(int i = 0; i < 5; i++)
        {
            int newRoll = Random.Range(1, 9);
            diceRolls.Add(newRoll);
        }

        //puts list in order from least to greatest and returns the 3 highest rolls
        diceRolls.Sort();
        return diceRolls[4] + diceRolls[3] + diceRolls[2];
    }

    //sets placeholder text to blank and sets input field to the rolled dice total
    public void Callback_Roll_STR()
    {
        eraseSTR.text = "";
        STR.text = Roll().ToString();
    }

    //sets placeholder text to blank and sets input field to the rolled dice total
    public void Callback_Roll_DEX()
    {
        eraseDEX.text = "";
        DEX.text = Roll().ToString();
    }

    //sets placeholder text to blank and sets input field to the rolled dice total
    public void Callback_Roll_CON()
    {
        eraseCON.text = "";
        CON.text = Roll().ToString();
    }

    //sets placeholder text to blank and sets input field to the rolled dice total
    public void Callback_Roll_INT()
    {
        eraseINT.text = "";
        INT.text = Roll().ToString();
    }

    //sets placeholder text to blank and sets input field to the rolled dice total
    public void Callback_Roll_WIS()
    {
        eraseWIS.text = "";
        WIS.text = Roll().ToString();
    }

    //sets placeholder text to blank and sets input field to the rolled dice total
    public void Callback_Roll_CHA()
    {
        eraseCHA.text = "";
        CHA.text = Roll().ToString();
    }

    //sets walking speed text to slider input
    public void Callback_Set_Walking_Speed(float walkVal)
    {
        Debug.Log("set walk speed to " + walkVal.ToString());
        WalkSpeed_Output.text = walkVal.ToString();

    }

    //sets running speed text to slider input
    public void Callback_Set_Running_Speed(float runVal)
    {
        Debug.Log("set run speed to " + runVal.ToString());
        RunSpeed_Output.text = runVal.ToString();

    }

    //sets jump height text to slider input
    public void Callback_Set_Jump_Height(float jumpVal)
    {
        Debug.Log("set jump height to " + jumpVal.ToString());
        JumpHeight_Output.text = jumpVal.ToString();

    }

}
