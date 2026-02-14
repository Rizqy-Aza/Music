using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    // Fungsi untuk pindah ke Scene Utama 
    public void SceneUtama ()
    {
        SceneManager.LoadScene (1);
    }

    // Fungsi untuk keluar aplikasi
    public void ExitButton ()
    {
        SceneManager.LoadScene("MainApp");
    }

    public void Drum()
    {
        SceneManager.LoadScene(2);
    }

    public void Xylophone()
    {
        SceneManager.LoadScene(3);
    }
    
    public void About ()
    {
        SceneManager.LoadScene (4);
    }
}