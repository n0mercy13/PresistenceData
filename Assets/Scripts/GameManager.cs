using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [HideInInspector]
    public string playerName;
    public string highScorePlayerName;
    public int highScore;

    private const string highScoreSave = "highScoreSave";
    private const string playerNameSave = "playerNameSave";

    private void Awake()
    {
        if(instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

        LoadHighScore();
        Debug.Log(highScorePlayerName + "/" + highScore);
    }

    public void SaveHighScore()
    {
        // Using PlayerPrefs:
        PlayerPrefs.SetInt(nameof(highScoreSave), highScore);
        PlayerPrefs.SetString(nameof(playerNameSave), highScorePlayerName);
        PlayerPrefs.Save();
    }

    public void LoadHighScore()
    {
        // Using PlayerPrefs:
        highScore = PlayerPrefs.GetInt(nameof(highScoreSave), 0);
        highScorePlayerName = PlayerPrefs.GetString(nameof(playerNameSave), "");
    }
}
