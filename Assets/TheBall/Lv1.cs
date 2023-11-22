using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lv1 : MonoBehaviour
{ 
    public void Mang1()
    {
    Application.LoadLevel ("Level1");
    }
    public void Mang2()
    {
    Application.LoadLevel ("Level2");
    }
    public void Mang3()
    {
    Application.LoadLevel ("Level3");
    }
    public void ExitPlay()
    {
    Application.LoadLevel ("MainMenu");
    }
    public void ExitIntruct()
    {
    Application.LoadLevel ("MainMenu");
    }
    public void ExitLevel1()
    {
    Application.LoadLevel("Level");
    }
     public void ExitLevel2()
    {
    Application.LoadLevel ("Level");
    }
     public void ExitLevel3()
    {
    Application.LoadLevel ("Level");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
