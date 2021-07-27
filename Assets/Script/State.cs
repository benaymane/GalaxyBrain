using UnityEngine;
using System;

[CreateAssetMenuAttribute(menuName = "State")]
public class State : ScriptableObject {
    //[SerializeField] bool questionState;
    [SerializeField] Question question;
    [SerializeField] Pokemon pokemon;
    [SerializeField] State rightState;
    [SerializeField] State leftState;

    public string getQuestionText() {
        return question.getQuestionText();
    }

    public State getRight() {
        return (rightState != null) ? rightState : throw new NullReferenceException("No Right Child!");
    }

    public State getLeft() {
        return (leftState != null) ? leftState : throw new NullReferenceException("No Left Child!");
    }

    public Pokemon getPokemon() {
        return pokemon;
    }
    public bool isLeaf() {
        return (pokemon != null) ? true : false;
    }
}