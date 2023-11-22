using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public void EndGame()
    {
        Application.LoadLevel ("Level");
    }
    public void Menu()
    {
        Application.LoadLevel ("MainMenu");
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
