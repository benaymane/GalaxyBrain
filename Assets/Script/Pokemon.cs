using UnityEngine;
using System;

[CreateAssetMenuAttribute(menuName = "Pokemon")]
public class Pokemon : ScriptableObject {
    [SerializeField] int number;
    [SerializeField] string[] types;
    [SerializeField] string pokeName;
    [SerializeField] Sprite pokeSprite;
    //Need picture holder

    public string getName() {
        return (String.IsNullOrWhiteSpace(pokeName)) ? "MISSING_NAME_ERROR" : pokeName;
    }

    public Sprite getSprite() {
        return pokeSprite;
    }

    public int getNumber() {
        return number;
    }

    public string toString() {
        return "" + number + " - " + getName();
    }
}
