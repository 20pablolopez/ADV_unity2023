using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class Jugar : MonoBehaviour
{
    public static Jugar instance;

      private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(gameObject);
        
    }
    
    public void Play()
    {
        SceneManager.LoadScene(1) ;
    }
}