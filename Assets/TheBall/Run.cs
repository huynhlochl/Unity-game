using System.Collections;//tập hợp các dữ liệu ko cùng kiểu, giúp cho lập trình viên thao tác đơn gainr và dễ dàng
using System.Collections.Generic;//truy cập các phần tử theo key
using UnityEngine;

public class Run : MonoBehaviour //là một lớp nền cho các script được gắn vào game object trong unity
{
    public int speed = 100;//khai báo về tốc độ của vật thể
    public int turningSpeed = 20;
    public int JumpForce = 20;// độ cao khi nhảy
    public Rigidbody RG;//định luật vật lý
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))//Input là một phần quan trọng dùng để lấy thông tin từ GetKey
        //GetKey là cách nhận input từ bàn phím thông qua class Input trong unity
        {
            //qua trai
            RG.AddForce(0f, 0f, -turningSpeed * Time.deltaTime, ForceMode.VelocityChange);//AddForce lực, -turningSpeed qua trái của z
            //Time.deltaTime là khoảng thời gian khung hình cuối cùng và khung hình hiện tại. giúp tốc độ di chuyển trở nên mượt hơn ko quá nhanh.
            //ForceMode.VelocityChange đổi tốc đọ khi đang di chuyển.
        }
        if (Input.GetKey(KeyCode.D))
        {
            //qua phai
            RG.AddForce(0f, 0f, turningSpeed * Time.deltaTime, ForceMode.VelocityChange);
        }
        if (Input.GetKey(KeyCode.S))
        {
            //nhảy xuống
            RG.AddForce(0f, -turningSpeed * Time.deltaTime , 0f, ForceMode.VelocityChange);
        }
         if (Input.GetKey(KeyCode.W))
        {
            //nhảy lên
            RG.AddForce(0f, JumpForce * Time.deltaTime, 0f, ForceMode.VelocityChange);
        }
    }
    private void FixedUpdate()//FixedUpdate thường sử dụng các tác vụ liên quan đến vật lý trong game
    {
      RG.AddForce(-speed * Time.deltaTime, 0, 0);//làm cho vật thể luôn di chuyển về phía trước
      RG.AddForce(-speed * Time.deltaTime, JumpForce * Time.deltaTime, 0);
    }
    private void OnCollisionEnter(Collision Collision)// được hiểu là sự va chạm của các vật thể
    {
        if (Collision.gameObject.CompareTag("VatCan"))// vật thể khi va chạm vào một vật thể khác chứa tap VatCan sẽ kết thúc game

        {
            //end game
            this.enabled = false;
           FindObjectOfType<GameSave>().EndGame();
        }
        if (Collision.gameObject.CompareTag("QuaMang"))
        {
            //mang 1
            this.enabled = false;
           FindObjectOfType<QuaMang>().NextGame();
        }
         if (Collision.gameObject.CompareTag("QuaMang3"))
        {
            //màng 2
            this.enabled = false;
           FindObjectOfType<QuaMang>().QuaMang3();
        }
        if (Collision.gameObject.CompareTag("VeDich"))
        {
            //màng 3
            this.enabled = false;
           FindObjectOfType<QuaMang>().Thang();
        }
    }
}
