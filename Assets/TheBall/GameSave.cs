using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//giúp cho ta có thể quản lý scene dễ dàng và trở nên nhẹ nhàng hơn
//SceneManagement là tập hợp các giao diện rải rác với nhau từ đó tạo thành một giao diện hợp nhất

public class GameSave : MonoBehaviour
{
   public void EndGame()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Application.LoadLevel ("GameOver");//là một ứng dụng dao diện điều khiển giúp cho việt đọc và viết ký tự từ một giao diện điểu khiển
   }
}