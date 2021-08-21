using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class UIHandler : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI bestScoreText;
    [SerializeField] InputField inputUI;
    [SerializeField] Button btnStart;
    [SerializeField] Button btnQuit;
    

    private void Start()
    {
        //inputUI.GetComponent<InputField>().onValueChanged.AddListener(ChangePlayerName);
        inputUI.onEndEdit.AddListener(ChangePlayerName);
        btnStart.onClick.AddListener(StartGame);
        btnQuit.onClick.AddListener(EndGame);
        if (GameManager.singleton != null)
            bestScoreText.text = GameManager.singleton.playerName + " : " + GameManager.singleton.bestScore;
    }

    void ChangePlayerName(string value)
    {
        GameManager.singleton.playerName = value;
    }

    void StartGame()
    {
        GameManager.singleton.SaveData();
        SceneManager.LoadScene("main");
    }

    void EndGame()
    {
#if UNITY_EDITOR
        GameManager.singleton.SaveData();
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
