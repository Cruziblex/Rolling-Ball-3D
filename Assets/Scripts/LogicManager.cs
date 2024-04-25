using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class LogicManager : MonoBehaviour
{
    private TextMeshProUGUI scoreText;
    public PlayerColliderScript playerColliderScript;
    public GameObject gameOver;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GameObject.FindGameObjectWithTag("Score").GetComponent<TextMeshProUGUI>();
        playerColliderScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerColliderScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerColliderScript.isDead == true)
        {
            gameOver.SetActive(true);
        }
    }
}
