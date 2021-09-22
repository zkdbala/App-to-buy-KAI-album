using UnityEngine;

public class URL : MonoBehaviour
{
    public string url;
    public void openurl()
    {
        Application.OpenURL(url);
    }
    
}
