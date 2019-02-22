using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RetryScript : MonoBehaviour {

    public static Button btn;

    void Start()
    {
        btn = GetComponent<Button>();
        btn.onClick.AddListener(Retry);
        Vector3 pos = btn.transform.position;
        pos.y -= 100;
        btn.transform.position = pos;
    }

    void Retry()
    {
        Scene loadedLevel = SceneManager.GetActiveScene();
        SceneManager.LoadScene(loadedLevel.buildIndex);
    }
}