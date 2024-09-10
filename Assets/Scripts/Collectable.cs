using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public CollectableType type;
    //Nhân vật đi nhặc Collectable
    // add collectable cho nhân vật
    //delete collectable from the screen
    private void OnTriggerEnter2D(Collider2D collision) //chức năng tích hợp cho phép khi chúng ta phát hiện có gì được đưa vào 
    {
        Player player = collision.GetComponent<Player>();//xem đối tượng trò chơi nhập trình kích hoạt 
        if (player)
        {
            player.inventory.Add(type);//thêm collectable 
             
            Destroy(this.gameObject); // delete collectable from the screen
        }
        
    }
}
public enum CollectableType// sưu tập 
{
    NONE ,CARROT_SEED , TOMATO_SEED
}
