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
        if (collected == 10)
        {
            statusText.text = "You Win!";
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("food"))
        {
            other.gameObject.SetActive(false);
            collected++;
            if(collected == 10)
            {
                thePlayer.transform.position = new Vector3(0, -100f, 0);
            }
        }
        if (other.gameObject.CompareTag("hitbox"))
        {
            gameover++;
            statusText.text = "Game Over";
            thePlayer.transform.position = new Vector3(0, -100f, 0);
        }
     
    }
}
