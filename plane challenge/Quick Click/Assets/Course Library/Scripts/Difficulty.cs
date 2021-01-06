using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Difficulty : MonoBehaviour
{
    private Button button;
    private GameManager gameManager;
    public int difficulty;

    // Start is called before the first frame update
    void Start()
    {
        //pull in gamemanager codes
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        //sets buttons
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficulty);
    }
    //sets different difficulties based on which button you push
    void SetDifficulty()
    {
        Debug.Log(gameObject.name + " was clicked");
        gameManager.StartGame(difficulty);
    }
}
