using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class gameBehaviour : MonoBehaviour
{
    public string labelText = "Collect all 4 items to proceed";
    public int maxItems = 4;

    public bool showWinScreen = false;

    private int itemsCollected = 0;
    public int Items
    {
        get { return itemsCollected; }

        set
        {
            itemsCollected = value;
            Debug.LogFormat("Items: {0}", itemsCollected);

            if(itemsCollected >= maxItems)
            {
                labelText = "You've found all items";
                showWinScreen = true;

                Time.timeScale = 0f;
            }
            else
            {
                labelText = "Item found, only " + (maxItems - itemsCollected) + " more to go";
            }
        }

    }

    private int playerHP = 10;
    public int HP
    {
        get { return playerHP; }
        set
        {
            playerHP = value;
            Debug.LogFormat("Lives: {0}", playerHP);
        }
    }

    void OnGUI()
    {
        GUI.Box(new Rect(20, 20, 150, 25), "Player Health:" + playerHP);

        GUI.Box(new Rect(20, 50, 150, 25), "Items Collected: " + itemsCollected);

        GUI.Label(new Rect(Screen.width / 2 - 100, Screen.height - 50, 300, 50), labelText);

        if (showWinScreen)
        {
            if(GUI.Button(new Rect(Screen.width/2 - 100, Screen.height/2 - 50, 200, 100), "You can now continue."))
            {
                SceneManager.LoadScene(0);

                Time.timeScale = 1.0f;
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}