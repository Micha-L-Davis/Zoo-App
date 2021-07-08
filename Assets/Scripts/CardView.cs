using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class CardView : MonoBehaviour
{
    public TextMeshProUGUI titleText;
    public TextMeshProUGUI descriptionText;
    public TextMeshProUGUI animalsText;
    public Image animalImage;

    private void OnEnable()
    {
        MapPanel.OnSelectExhibit += FillCardData;
    }

    public void FillCardData(CardModel card)
    {
        this.titleText.text = card.title;
        this.descriptionText.text = card.description;
        this.animalsText.text = card.animals;
        this.animalImage.sprite = card.animalImage;
    }
}
