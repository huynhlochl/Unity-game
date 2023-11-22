using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuaMang : MonoBehaviour
{
   public void NextGame()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
      Application.LoadLevel ("Level2");
   }
   
   public void QuaMang3()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
      Application.LoadLevel ("Level3");
   }
   public void Thang()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
      Application.LoadLevel ("ChienThang");
   }
}
