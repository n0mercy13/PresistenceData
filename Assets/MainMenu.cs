using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MainMenu : MonoBehaviour
{
    [SerializeField] TMP_InputField playerInput;    

    public void StartGame()
    {
        if(string.IsNullOrEmpty(playerInput.textComponent.text))
        {
            playerInput.text = "Please, type your name";
        }
        else
        {
            GameManager.instance.playerName = playerInput.textComponent.text;
            Debug.Log(GameManager.instance.playerName);
            SceneManager.LoadScene(1);
        }        
    }
    public void QuitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
