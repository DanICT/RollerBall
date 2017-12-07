using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public PlayerController player;
    public UIController uiController;
    public GameObject[] pickups;
    public float time;
    private bool gameIsWon;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void updateCountUI(int count)
    {
        this.uiController.SetCountText(count);
    }

    public void setGameIsWon(bool isWon)
    {
        this.gameIsWon = isWon;
        if (isWon == false)
        {
            this.uiController.SetWinText("You lost!");
            this.resetGame();
        }
        else
        {
            this.uiController.SetWinText("You won!");
        }
    }

    private void resetGame()
    {
        foreach (GameObject p in this.pickups)
        {
            p.SetActive(true);
        }
        this.player.resetPlayer();
        this.uiController.SetCountText(0);
        this.uiController.SetWinText("");
    }
}
