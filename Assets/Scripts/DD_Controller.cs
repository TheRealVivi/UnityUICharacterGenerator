using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DD_Controller : MonoBehaviour
{
    public Dropdown ddRaces;
    public Dropdown ddClasses;
    public Dropdown ddAlignment;
    public Dropdown ddStrength;
    public Dropdown ddDexterity;
    public Dropdown ddConstitution;
    public Dropdown ddIntelligence;
    public Dropdown ddWisdom;
    public Dropdown ddCharisma;

    public Text finished;
    public List<string> abilities = new List<string>();
    public List<Text> roll = new List<Text>();
    public int abilityctr = 1;

    public class Classes
    {
        public static List<string> classes = new List<string>() { "Class", "Barbarian", "Bard", "Cleric", "Druid", "Fighter", "Monk", "Paladin", "Ranger", "Rogue", "Sorcerer", "Warlock", "Wizard" };
    }

    public class Races
    {
        public static List<string> races = new List<string>() { "Race", "Dragonborn", "Dwarf", "Elf", "Gnome", "Half-Elf", "Half-Orc", "Halfling", "Human", "Tiefling" };
    }

    public class Alignment
    {
        public static List<string> alignment = new List<string>() { "Alignment", "Lawful Good", "Neutral Good", "Chaotic Good", "Lawful Neutral", "Neutral", "Chaotic Neutral", "Lawful Evil", "Neutral Evil", "Chaotic Evil" };
    }

    // Start is called before the first frame update
    void Start()
    {
        PopulateRaceDD();
        PopulateClassDD();
        PopulateAlignmentDD();
    }

    public void PopulateRaceDD()
    {
        ddRaces.AddOptions(Races.races);
    }

    public void PopulateClassDD()
    {
        ddClasses.AddOptions(Classes.classes);
    }

    public void PopulateAlignmentDD() 
    {
        ddAlignment.AddOptions(Alignment.alignment);
    }

    public void PopulateAbilitiesDD() 
    {
        if (abilityctr == 7)
        {
            ddStrength.AddOptions(abilities);
            ddDexterity.AddOptions(abilities);
            ddConstitution.AddOptions(abilities);
            ddIntelligence.AddOptions(abilities);
            ddWisdom.AddOptions(abilities);
            ddCharisma.AddOptions(abilities);
        }
    }

    public void ClassChanged(int index)
    {
        Player.Instance.classtype = Classes.classes[index];
    }

    public void RaceChanged(int index)
    {
        Player.Instance.race = Races.races[index];
    }

    public void AlignmentChanged(int index) 
    {
        Player.Instance.alignment = Alignment.alignment[index];
    }

    public void StrengthChanged(int index)
    {
        Player.Instance.strength = float.Parse(abilities[index]);
    }

    public void DexterityChanged(int index)
    {
        Player.Instance.dexterity = float.Parse(abilities[index]);
    }

    public void ConstitutionChanged(int index)
    {
        Player.Instance.constitution = float.Parse(abilities[index]);
    }

    public void IntelligenceChanged(int index)
    {
        Player.Instance.intelligence = float.Parse(abilities[index]);
    }

    public void WisdomChanged(int index)
    {
        Player.Instance.wisdom = float.Parse(abilities[index]);
    }

    public void CharismaChanged(int index)
    {
        Player.Instance.charisma = float.Parse(abilities[index]);
    }


    public static int Roll()
    {
        return Random.Range(1, 7);
    }


    public void RollAbility()
    {
        if (abilityctr < 7)
        {
            string myText;
            int min1 = 0, min2 = 1, sum = 0, i;
            for (i = 0; i < 5; i++)
            {
                if (i == 0)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        roll[j].text = " ";
                    }
                }

                myText = Roll().ToString();
                roll[i].text = myText;
            }

            if (i == 5)
            {

                for (int j = 1; j < 5; j++)
                {
                    if (int.Parse(roll[min1].text) > int.Parse(roll[j].text))
                        min1 = j;
                }

                if (min1 == min2)
                    min2 = 0;

                for (int j = 0; j < 5; j++)
                {
                    if (j != min1 && int.Parse(roll[min2].text) > int.Parse(roll[j].text))
                        min2 = j;
                }

                for (int j = 0; j < 5; j++)
                    sum += int.Parse(roll[j].text);

                sum -= int.Parse(roll[min1].text);
                sum -= int.Parse(roll[min2].text);

                myText = sum.ToString();
                roll[i].text = "Total: " + myText;

                if (sum + 2 < 20)
                    sum += 2;

                if (sum > 20)
                    sum = 20;

                myText = sum.ToString();
                abilities[abilityctr] = myText;
                abilityctr++;
                PopulateAbilitiesDD();
            }
        }
        else
            finished.text = "You have already rolled all of your abilities!";
    }
}
