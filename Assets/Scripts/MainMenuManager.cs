using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // <- per usare funzioni e metodi ad hoc

public class MainMenuManager : MonoBehaviour
{
    [Header("Panels")]
    public GameObject mainMenuPanel;
    public GameObject optionsPanel;
    public GameObject creditsPanel;

    [Header("Buttons")]
    public Button loadGameButton;

    void Start()
    {
        // Disattiva pannelli secondari all'avvio
        mainMenuPanel.SetActive(true);
        optionsPanel.SetActive(false);
        creditsPanel.SetActive(false);

        // Rendi Load Game non interagibile
        loadGameButton.interactable = false;
    }

    // MENU PRINCIPALE
    public void OnNewGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void OnLoadGame()
    {
        Debug.Log("Load Game premuto, ma è disabilitato.");
    }

    public void OnOptions()
    {
        mainMenuPanel.SetActive(false);
        optionsPanel.SetActive(true);
    }

    public void OnCredits()
    {
        mainMenuPanel.SetActive(false);
        creditsPanel.SetActive(true);
    }

    public void OnExit()
    {
        Debug.Log("Sei uscito dal gioco.");
        Application.Quit();
    }

    // OPZIONI
    public void OnSaveOptions()
    {
        Debug.Log("Le opzioni sono state salvate.");
    }

    public void OnReturnFromOptions()
    {
        optionsPanel.SetActive(false);
        mainMenuPanel.SetActive(true);
    }

    // CREDITI
    public void OnReturnFromCredits()
    {
        creditsPanel.SetActive(false);
        mainMenuPanel.SetActive(true);
    }
}
