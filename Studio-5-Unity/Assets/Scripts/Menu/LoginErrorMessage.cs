using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Networking;

public class LoginErrorMessage : MonoBehaviour
{
    private TMP_Text debugDialog;
    // Start is called before the first frame update
    void Start()
    {
        debugDialog = gameObject.GetComponent<TMP_Text>();
    }
}
