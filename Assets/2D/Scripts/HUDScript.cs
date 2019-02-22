using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HUDScript : MonoBehaviour {

    public static float scoreValue = 0;
    int scoreValueInt = 0;
    Text score;

    void Start()
    {
        score = GetComponent<Text>();
        scoreValue = 0;
        scoreValueInt = 0;
        Vector3 pos = score.transform.position;
        pos.y += Screen.height/3;
        pos.x -= Screen.width/3;
        score.transform.position = pos;
    }

    void Update ()
    {
        if(GameObject.Find("CharacterRobotBoy") != null)
        {
            scoreValue += Time.deltaTime;
            scoreValueInt = (int)scoreValue;
            score.text = "Score: " + scoreValueInt;
            RetryScript.btn.gameObject.SetActive(false);
        }
        else
        {
            score.text = "GAME OVER :( \n Final score: " + scoreValueInt;
            RetryScript.btn.gameObject.SetActive(true);
        }
	}
}