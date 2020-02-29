using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Player : MonoBehaviour
{
    private static Player instance;
    public static Player Instance { get { return instance; } }
    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            DontDestroyOnLoad(this.gameObject);
            instance = this;
        }
    }

    
    public string cname;
    public string classtype;
    public string race;
    public string alignment = "neutral";
    public int hp = 10;
    public int maxhp = 100;
    public int xp = 1;
    public int maxxp = 1;
    public int armorClass;
    public int walkingSpeed = 0;
    public int runningSpeed = 0;
    public int jumpHeight = 0;
    public float strength = 15;
    public float dexterity = 15;
    public float constitution = 15;
    public float intelligence = 15;
    public float wisdom = 15;
    public float charisma = 15;

    public List<string> itemList = new List<string>();

    public void CharacterStats() 
    {
        Debug.Log(this.cname + " " + this.race + " " + this.classtype + " " + this.strength + " " + this.dexterity + " " + this.constitution + " " + this.intelligence + " " + this.wisdom + " " + this.charisma);
    }

    public void DefaultBuild() 
    {
        this.strength = 15;
        this.dexterity = 14;
        this.constitution = 13;
        this.intelligence = 12;
        this.wisdom = 10;
        this.charisma = 8;
    }
}
