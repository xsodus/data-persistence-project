using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    public string playerName;
    public int bestScore;
    public static StateManager Instance { get; private set; }

    private void Awake()
    {
        if(Instance == null)
        {
            DontDestroyOnLoad(this);
            Instance = this;
            playerName = PlayerPrefs.GetString("playerName", "");
            bestScore = PlayerPrefs.GetInt("bestScore", 0);
        } else
        {
            Destroy(this);
        }
    }

    public string buildBestScoreText()
    {
        return $"Best Score : {StateManager.Instance.playerName} : {StateManager.Instance.bestScore}";
    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.SetString("playerName", playerName);
        PlayerPrefs.SetInt("bestScore", bestScore);
    }
}
