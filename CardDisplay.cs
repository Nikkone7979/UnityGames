using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{
    public Card card;
    public Text NameText;
    public Text SpecialEffect;
    public Text AttackText;
    public Image ArtWork;

    void Start()
    {
        NameText.text = card.cardname;
        SpecialEffect.text = card.specialeffect;
        AttackText.text = "Attack: " + card.attack.ToString();
        ArtWork.sprite = card.artwork;
        
    }
}
