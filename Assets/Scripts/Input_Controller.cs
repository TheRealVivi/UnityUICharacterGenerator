using UnityEngine;
using UnityEngine.UI;

public class Input_Controller : MonoBehaviour
{
    public InputField json;

    public void JsonGen() 
    {
        json.text = JsonUtility.ToJson(Player.Instance);
    }

    public void ChangeName(string cname)
    {
        Player.Instance.cname = cname;
    }

    public void ChangeHP(string hp) 
    {
        Player.Instance.hp = int.Parse(hp);
    }

    public void ChangeMaxHP(string maxhp)
    {
        Player.Instance.maxhp = int.Parse(maxhp);
    }


    public void ChangeXP(string xp) 
    {
        Player.Instance.xp = int.Parse(xp);
    }

    public void ChangeMaxXP(string maxxp)
    {
        Player.Instance.maxxp = int.Parse(maxxp);
    }


    public void ChangeArmorClass(string armor) 
    {
        Player.Instance.armorClass = int.Parse(armor);
    }

    public void ChangeSpeed(string speed)
    {
        Player.Instance.walkingSpeed = int.Parse(speed);
        Player.Instance.runningSpeed = int.Parse(speed);
        Player.Instance.jumpHeight = int.Parse(speed);
    }

}
