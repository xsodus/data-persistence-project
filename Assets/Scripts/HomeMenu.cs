using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class HomeMenu : MonoBehaviour
{
    public TMP_Text bestScoreText;
    public TMP_InputField inputField;
    public Button startButton;
    public Button quitButton;

    // Start is called before the first frame update
    void Start()
    {
        startButton.onClick.AddListener(StartGame);
        quitButton.onClick.AddListener(Quit);
        bestScoreText.text = StateManager.Instance.buildBestScoreText();
    }

    void StartGame()
    {
        if (StateManager.Instance.playerName != inputField.text && inputField.text.Length > 0)
        {
            StateManager.Instance.playerName = inputField.text;
            StateManager.Instance.bestScore = 0;
        }
        SceneManager.LoadScene("main",LoadSceneMode.Single);
    }

    void Quit()
    {
        Application.Quit();
    }
}
