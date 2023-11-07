using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConsoleMessages : MonoBehaviour
{
    private EventMaster em;

    private void Awake()
    {
        em = GetComponent<EventMaster>();
    }


    private void OnEnable()
    {
        em.KeyPress += PrintPressedKey;
    }

    private void OnDisable()
    {
        em.KeyPress -= PrintPressedKey;
    }


    private void PrintPressedKey(char key)
    {
        Debug.Log(key.ToString());
    }
}
