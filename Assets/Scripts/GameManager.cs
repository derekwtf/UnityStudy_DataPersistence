using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager singleton;
    public string playerName = "Player";
    public int bestScore;
    private void Awake()
    {
        if (singleton == null)
        {
            singleton = this;
            LoadData();
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    
    [Serializable]
    class PlayerData
    {
        public string playerName;
        public int bestScore;
    }

    public void SaveData()
    {
        PlayerData data = new PlayerData();
        data.playerName = playerName;
        data.bestScore = bestScore;

        string path = Application.persistentDataPath + "/save.json";
        string json = JsonUtility.ToJson(data);
        File.WriteAllText(path, json);
    }

    public void LoadData()
    {
        string path = Application.persistentDataPath + "/save.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            PlayerData data = JsonUtility.FromJson<PlayerData>(json);
            playerName = data.playerName;
            bestScore = data.bestScore;
        }
    }
}
