using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Button : MonoBehaviour
{
    public GameObject Text;

    public void OnButtonClick()
    {
        Destroy(Text);
    }
}
