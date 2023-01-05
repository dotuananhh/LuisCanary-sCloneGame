using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FruitManager : MonoBehaviour
{
    public Text levelCleared;

    public GameObject transition;

    public Text totalFruits;    //Tổng số lượng trái cây ban đầu

    public Text fruitsCollected;    //Số lượng trái cây đã ăn

    private int totalFruitsInLevel;

    private void Start()
    {
        totalFruitsInLevel = transform.childCount;
    }

    private void Update()
    {
        AllFruitsCollected();
        totalFruits.text = totalFruitsInLevel.ToString();
        fruitsCollected.text = transform.childCount.ToString();
    }
    //Hàm này quản lý số lượng trái cây trong trò chơi
    public void AllFruitsCollected()
    {
        //Khi số lượng trái cậy = 0
        if(transform.childCount == 0)
        {
            //Hiển thị thông báo chúc mừng
            levelCleared.gameObject.SetActive(true);
            transition.SetActive(true); //Kích hoạt animation chuyển màn
            Invoke("ChangeScene", 1);   //Delay khoảng 2 s trước khi chuyển màn
        }
    }
    void ChangeScene()
    {
        //Chuyển màn hình khi ăn hết số quả
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
