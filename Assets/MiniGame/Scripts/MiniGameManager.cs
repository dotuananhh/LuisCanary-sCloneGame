using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MiniGameManager : MonoBehaviour
{
    public Text puntuacionText;

    public float puntuacionValue = 0;

    public Text maxPuntuacionText;

    public float maxPuntuacionValue = 0;

    public Text pointText;

    public int pointValue = 0;

    public Text maxPointText;

    public int maxPointValue = 0;

    private void Start()
    {
        maxPuntuacionValue = PlayerPrefs.GetFloat("MaxPuntuacion");
        maxPuntuacionText.text = maxPuntuacionValue.ToString("0.00");
        maxPointValue = PlayerPrefs.GetInt("MaxPoint");
        maxPointText.text = maxPointValue.ToString();
    }
    void Update()
    {
        puntuacionValue += Time.deltaTime;

        puntuacionText.text = puntuacionValue.ToString("0.00");

        if (maxPuntuacionValue < puntuacionValue)
        {
            PlayerPrefs.SetFloat("MaxPuntuacion", puntuacionValue);

            maxPuntuacionText.text = puntuacionValue.ToString("0.00");
        }
    }
    public void AddPoint(int value)
    {
        pointValue += value;
        pointText.text = pointValue.ToString();
        if (maxPointValue < pointValue)
        {
            PlayerPrefs.SetInt("MaxPoint", pointValue);
            maxPointText.text = pointValue.ToString();
        }
    }
}
