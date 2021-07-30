using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[CreateAssetMenuAttribute(menuName = "Pokemon")]
public class Pokemon : ScriptableObject {
    [SerializeField] int number;
    [SerializeField] string[] types;
    [SerializeField] string pokeName;
    //Need picture holder

    public string getName() {
        return (String.IsNullOrWhiteSpace(pokeName)) ? "MISSING_NAME_ERROR" : pokeName;
    }

    public int getNumber() {
        return number;
    }
}
