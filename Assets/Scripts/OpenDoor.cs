using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OpenDoor : MonoBehaviour
{
    public Text text;   //Đại diện cho TextOpenDoor
    public string levelName;    //Đại diện cho từng level
    private bool inDoor = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Khi Player đứng ở vị trí 1 cánh cửa level 
        if (collision.gameObject.CompareTag("Player"))
        {
            text.gameObject.SetActive(true);
            inDoor = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        text.gameObject.SetActive(false);
        inDoor = false;
    }

    private void Update()
    {
        //Khi Player đứng ở vị trí cánh cửa và nhấn nút e để đi vào
        if(inDoor && Input.GetKey("e"))
        {
            SceneManager.LoadScene(levelName);
        }
    }
}
