using UnityEngine;
using System.Collections;

public class DestroyerScript : MonoBehaviour {
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(collision.gameObject.transform.parent.gameObject);
        }
    }
}