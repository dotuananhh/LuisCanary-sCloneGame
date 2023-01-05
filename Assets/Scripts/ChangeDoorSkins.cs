using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeDoorSkins : MonoBehaviour
{
    public GameObject skinsPanel;

    public bool inDoor = false;

    public GameObject player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Kích hoạt bảng điều khiển khi Player va chạm với cánh cửa Skin
        if (collision.CompareTag("Player"))
        {
            skinsPanel.gameObject.SetActive(true);
            inDoor = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        skinsPanel.gameObject.SetActive(false);
        inDoor = false;
    }

    //Thiết lập nhân vật Frog
    public void SetPlayerFrog()
    {
        PlayerPrefs.SetString("playerSelected", "Frog");
        ResetPlayerSkin();
    }
    public void SetPlayerMaskDude()
    {
        PlayerPrefs.SetString("playerSelected", "MaskDude");
        ResetPlayerSkin();
    }
    public void SetPlayerPinkMan()
    {
        PlayerPrefs.SetString("playerSelected", "PinkMan");
        ResetPlayerSkin();
    }
    public void SetPlayerVirtualGuy()
    {
        PlayerPrefs.SetString("playerSelected", "VirtualGuy");
        ResetPlayerSkin();
    }

    void ResetPlayerSkin()
    {
        skinsPanel.gameObject.SetActive(false); //Tắt bảng điều khiển
        player.GetComponent<PlayerSelect>().ChangePlayerInMenu();
    }
}
