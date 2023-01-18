using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class pausemenu : MonoBehaviour
{
    public GameObject pausep;
    public int deger;
    // Start is called before the first frame update
    void Start()
    {
        pausep.SetActive(false);
        deger = PlayerPrefs.GetInt("level");
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void buttondan_gelen(string ne_geldi)
    {
        if (ne_geldi == "pause")
        {
            pausep.SetActive(true);
            Time.timeScale = 0;
        }
        else if (ne_geldi == "devamet")
        {
            pausep.SetActive(false);
            Time.timeScale = 1;
        }
        else if (ne_geldi == "yeniden")
        {
            Application.LoadLevel(deger);
            Time.timeScale= 1;
        }
        else if (ne_geldi == "quit")
        {
            Application.Quit();
            Debug.Log("Quit!");
        }
    }
    public void hangi_level(int level)
    {
        deger = level;
        PlayerPrefs.SetInt("level", deger);
    }


}
