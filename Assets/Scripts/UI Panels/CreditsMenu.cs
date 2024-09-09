using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsMenu : MonoBehaviour
{
    [Header("Panels")]
    public GameObject panelCredits;

    public void ShowCredits()
    {
        panelCredits.SetActive(true);
    }

    public void HideCredits()
    {
        panelCredits.SetActive(false);
    }
}
