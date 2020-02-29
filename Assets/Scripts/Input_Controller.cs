using UnityEngine;
using UnityEngine.UI;

public class Input_Controller : MonoBehaviour
{
    public void ChangeName(string cname)
    { 
        Player.Instance.cname = cname;
    }

    public void ChangeHP(string hp) 
    {
        if(!hp.Equals(""))
            Player.Instance.hp = int.Parse(hp);
    }

    public void ChangeMaxHP(string maxhp)
    {
        if(!maxhp.Equals(""))
            Player.Instance.maxhp = int.Parse(maxhp);
    }


    public void ChangeXP(string xp) 
    {
        if(!xp.Equals(""))
            Player.Instance.xp = int.Parse(xp);
    }

    public void ChangeMaxXP(string maxxp)
    {
        if(!maxxp.Equals(""))
            Player.Instance.maxxp = int.Parse(maxxp);
    }


    public void ChangeArmorClass(string armor) 
    {
        if(!armor.Equals(""))
            Player.Instance.armorClass = int.Parse(armor);
    }

    public void ChangeSpeed(string speed)
    {
        if (!speed.Equals(""))
        {
            Player.Instance.walkingSpeed = int.Parse(speed);
            Player.Instance.runningSpeed = int.Parse(speed);
            Player.Instance.jumpHeight = int.Parse(speed);
        }
    }

}
