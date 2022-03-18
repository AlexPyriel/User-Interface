using UnityEngine;
using TMPro;

public class DropDownOptionToText : MonoBehaviour
{
    public TMP_Text Text;
    public TMP_Dropdown Dropdown;

    public void DropdownToText(int num)
    {
        Text.text = Dropdown.options[num].text;
    }
}
