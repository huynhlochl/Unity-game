using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void StartGame(){
    
        Application.LoadLevel ("Play");
    }
    public void OptionsMenu()
    {
        Application.LoadLevel ("OptionMenu");
    }
    public void Intruct()
    {
        Application.LoadLevel ("InsTruct");
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit!");
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
