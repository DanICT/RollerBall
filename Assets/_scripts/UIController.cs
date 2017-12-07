using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour {
    public Text countText;
    public Text winText;

    public void SetWinText(string wintext)
    {
        this.winText.text = wintext;
    }

    public void SetCountText(int count)
    {
        this.countText.text = "Count: " + count.ToString();
    }
    // Use this for initialization
    void Start () {
        this.winText.text = "";
        this.countText.text = "Count: 0";
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
