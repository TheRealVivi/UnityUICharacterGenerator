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
    public string alignment;
    public int hp;
    public int maxhp;
    public int xp;
    public int maxxp;
    public int armorClass;
    public int walkingSpeed;
    public int runningSpeed;
    public int jumpHeight;
    public float strength;
    public float dexterity;
    public float constitution;
    public float intelligence;
    public float wisdom;
    public float charisma;

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
