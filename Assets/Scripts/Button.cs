using UnityEngine;

public class Button : MonoBehaviour
{
    public GameObject Text;

    public void OnButtonClick()
    {
        Destroy(Text);
    }
}
