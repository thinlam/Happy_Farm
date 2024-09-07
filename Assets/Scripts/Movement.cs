using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 2;

    public Animator animator;

    private Vector3 direction;
    // get input from player
    // apply movement to sprite 

    private void Update() // bản cập nhật thường xuyên 
    {
        
        float horizontal = Input.GetAxisRaw("Horizontal");//Left right (trái phải)
        
        float vertical = Input.GetAxisRaw("Vertical");//Up Down (lên xuống) 

        direction = new Vector3(horizontal, vertical, 0);
        AnimateMovement(direction);// Chức năng chuyển động hoạt hình và chuyển hướng vào nó . 
        
    }
    private void FixedUpdate() // bản cập nhật cố định 
    {
        transform.position += direction * speed * Time.deltaTime;//move the player
    }
    private void AnimateMovement(Vector3 direction)
    {
        if (animator != null) // if này để kiểm tra gúa trị của trình hoạt ảnh có phải là NULL hay không 
        {
            if (direction.magnitude > 0)// if này để kiểm tra độ lớn cửa vector chỉ phương có lớn hơn 0 không 
            {
                animator.SetBool("IsMoving", true);// 
                animator.SetFloat("horizontal", direction.x);//di chuyển hướng trái phải(left right) thì đặt chiều ngang thành Direction.x 
                animator.SetFloat("vertical", direction.y);//di chuyển hướng Lên xuống(Up Down) thì đặt chiều dọc thành Direction.y 
            }
            else
            {
                animator.SetBool("IsMoving", false);//
            }
        }
    }

}
