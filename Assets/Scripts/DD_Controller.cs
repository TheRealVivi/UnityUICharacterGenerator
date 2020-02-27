using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DD_Controller : MonoBehaviour
{
    public Dropdown ddRaces;
    public Dropdown ddClasses;
    // Start is called before the first frame update
    void Start()
    {
        PopulateRaceDD();
        PopulateClassDD();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PopulateRaceDD()
    {
        ddRaces.AddOptions(UI_Controller.Races.races);
    }

    public void PopulateClassDD()
    {
        ddClasses.AddOptions(UI_Controller.Classes.classes);
    }

    public void ClassChanged(int index)
    {
        //TODO: logic to recieve text
        Player.classtype = UI_Controller.Classes.classes[index];
    }

    public void RaceChanged(int index)
    {
        //TODO: logic to recieve text
        Player.race = UI_Controller.Races.races[index];
    }
}
