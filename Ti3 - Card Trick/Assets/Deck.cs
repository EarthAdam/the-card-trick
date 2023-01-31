using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    public GameObject cardPrefab;
    public List<Sprite> cardFaces;
    private List<GameObject> cards;

    private void Start()
    {
        cards = new List<GameObject>();
        for (int i = 0; i < cardFaces.Count; i++)
        {
            GameObject card = Instantiate(cardPrefab, transform);
            card.GetComponent<SpriteRenderer>().sprite = cardFaces[i];
            cards.Add(card);
        }
    }
}
