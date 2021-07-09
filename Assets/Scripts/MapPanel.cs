using System;
using UnityEngine;


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
