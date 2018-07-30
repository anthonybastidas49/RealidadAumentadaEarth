using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
    public void tierra()
    {
        SceneManager.LoadScene("Tierra");
    }
    public void capasTierra()
    {
        SceneManager.LoadScene("TierraCapas");
    }
    public void TeoriaTierra()
    {
        SceneManager.LoadScene("TeoriaTierra");
    }
}
