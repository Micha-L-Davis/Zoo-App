using UnityEngine;


[CreateAssetMenu(fileName = "New Card", menuName = "Cards")]
public class CardModel : ScriptableObject
{
    public string title;
    public string description;
    public string animals;
    public Sprite animalImage;
}
