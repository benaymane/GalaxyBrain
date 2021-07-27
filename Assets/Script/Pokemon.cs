using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenuAttribute(menuName = "Pokemon")]
public class Pokemon : ScriptableObject
{
    [SerializeField] int number;
    [SerializeField] string[] types;
    [SerializeField] string pokeName;
    //Need picture holder

    public string getName() {
        return pokeName;
    }

    public int getNumber() {
        return number;
    }
}
