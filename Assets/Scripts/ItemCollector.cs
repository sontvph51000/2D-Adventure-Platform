using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{

    private int apples = 0;
    [SerializeField] private Text applesText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Apple"))
        {
            AudioManager.instance.Play("Collect");
            Destroy(collision.gameObject);
            apples++;
            applesText.text = "Apples: " + apples;
        }
    }
}
