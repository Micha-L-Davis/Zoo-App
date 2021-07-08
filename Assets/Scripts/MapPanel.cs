using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MapPanel : MonoBehaviour
{
    public static Action<CardModel> OnSelectExhibit;
    public GameObject cardPanel;

    public void SelectExhibit(CardModel card)
    {
        cardPanel.SetActive(true);
        if (OnSelectExhibit != null)
        {
            OnSelectExhibit(card);
        }
    }
}
