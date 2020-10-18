using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PelletCollect : MonoBehaviour
{
    public Text statusText;
    public GameObject thePlayer;

    public int collected = 0;
    public int gameover = 0;
    [SerializeField]
    private void Start()
    {
        statusText.text = " ";
    }

    void Update()
    {
        if (collected == 4)
        {
            statusText.text = "You Win!";
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            collected++;
        }
        if (other.gameObject.CompareTag("ghost"))
        {
            gameover++;
            statusText.text = "Game Over";
            thePlayer.transform.position = new Vector3(0, -100f, 0);
        }
     
    }
}
