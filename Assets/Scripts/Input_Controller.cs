using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Input_Controller : MonoBehaviour
{
    public InputField nameInput;

    public void ChangeName(string cname) 
    {
        Player.cname = cname;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
