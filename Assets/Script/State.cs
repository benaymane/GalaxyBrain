using UnityEngine;
using System;

[CreateAssetMenuAttribute(menuName = "State")]
public class State : ScriptableObject {
    //[SerializeField] bool questionState;
    [SerializeField] Question question;
    [SerializeField] Pokemon pokemon;
    [SerializeField] State rightState;
    [SerializeField] State leftState;
    [SerializeField] State parentState;

    public string getQuestionText() {
        if(question != null) {
            return question.getQuestionText();
        }
        return "NO_QUESTION_ERROR";
    }

    public State getRight() {
        return rightState;
    }

    public State getLeft() {
        return leftState;
    }

    public State getParent() {
        return parentState;
    }

    public Pokemon getPokemon() {
        return pokemon;
    }

    public bool isLeaf() {
        return (pokemon != null) ? true : false;
    }
}