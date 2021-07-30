using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Game : MonoBehaviour
{
    [SerializeField] State currentState;
    [SerializeField] TMP_Text gameText;
    [SerializeField] Button yesButton;
    [SerializeField] Button noButton;

    // Start is called before the first frame update
    void Start() {
        updateQuestionText();
    }

    public void traverseRight() {
        if(currentStateIsNull()) return;
        currentState = currentState.getRight();
        updateQuestionText();
    }

    public void traverseLeft() {
        if(currentStateIsNull()) return;
        currentState = currentState.getLeft();
        updateQuestionText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void updateQuestionText() {
        if(currentStateIsNull()) return;

        if (currentState == null) {
            return;
        }
        
        if (currentState.isLeaf()) {
            gameText.text = currentState.getPokemon().getName();
        }
        else {
            gameText.text = currentState.getQuestionText();
        }
    }

    private bool currentStateIsNull() {
        return currentState == null;
    }
}