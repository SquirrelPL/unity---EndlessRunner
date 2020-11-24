using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class GameManagerScript : MonoBehaviour
{
    public TextMeshProUGUI score;
    public TextMeshProUGUI deadScore;

    public Transform player;
    public GameObject deadPlate;

    void Start()
    {
        Time.timeScale = 1;
        deadPlate.SetActive(false);
        score.enabled = true;
    }

    void LateUpdate()
    {
        score.text = player.position.z.ToString("F");
    }

    public void hit()
    {
        Time.timeScale = 0;
        deadPlate.SetActive(true);
        deadScore.text = player.position.z.ToString("F");
        score.enabled = false;
    }

    public void onRestartButton()
    {
        SceneManager.LoadScene(0);
    }


}
