using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRespawn : MonoBehaviour
{

    private float checkPointPositionX, checkPointPositionY;

    public Animator animator;
    public int life;
    public GameObject[] hearts;
    void Start()
    {
        life = hearts.Length;
        if (PlayerPrefs.GetFloat("checkPointPositionX") != 0)
        {
            transform.position = (new Vector2(PlayerPrefs.GetFloat("checkPointPositionX"), PlayerPrefs.GetFloat("checkPointPositionY")));
        }
    }
    private void CheckLife()
    {
        if (life < 1)
        {
            Destroy(hearts[0].gameObject);
            animator.Play("Hit");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        }
        else if (life < 2)
        {
            Destroy(hearts[1].gameObject); 
            animator.Play("Hit");
        }
        else if(life < 3)
        {
            Destroy(hearts[2].gameObject);
            animator.Play("Hit");
        }
    }
    //Lưu vị trí người chơi để hồi sinh
    public void ReachedCheckPoint(float x,float y)
    {
        PlayerPrefs.SetFloat("checkPointPositionX",x);
        PlayerPrefs.SetFloat("checkPointPositionY", y);
    }

    //Khi người chơi chết sẽ quay lại từ đầu màn chơi
    public void PlayerDeath()
    {
        animator.Play("Hit");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void PlayerDamaged()
    {
        life--;
        CheckLife();
    }

}
