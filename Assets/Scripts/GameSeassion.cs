using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameSeassion : MonoBehaviour
{
    [SerializeField] int playersLives = 4;
    [SerializeField] TextMeshProUGUI livesText;
    // Start is called before the first frame update
    void Awake()
    {
        int numGameSeassions = FindObjectsOfType<GameSeassion>().Length;
        if (numGameSeassions > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
     void Start()
    {
        livesText.text = playersLives.ToString();
    }
    public void ProcessPlayerDeath()
    {
        if(playersLives > 0)
        {
            TakeLife();
        }
        else
        {
            ResetGameSeassion();
        }
    }
    void TakeLife()
    {
        playersLives--;
        livesText.text = playersLives.ToString();
    }
    void ResetGameSeassion()
    {
        SceneManager.LoadScene(0);
       // Destroy(gameObject);
    }



}
