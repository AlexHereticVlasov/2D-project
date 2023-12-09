using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneLoad : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;

    public void OnPresed()
    {
        SceneManager.LoadScene(1);
    }

}
