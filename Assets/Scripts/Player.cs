using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static string cname;
    public static string classtype;
    public static string race;

    public static int hp;
    public static int xp;

    /*
    public Player()
    {
        this.name = "John";
        this.classtype = null;
        this.race = null;
    }
    public Player(string classtype, string race)
    {
        this.classtype = classtype;
        this.race = race;
    }
    */
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CharacterStats() 
    {
        Debug.Log(cname + " " + race + " " + classtype);
    }
}
