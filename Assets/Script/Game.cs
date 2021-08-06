using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class Game : MonoBehaviour
{
    [SerializeField] State currentState;
    [SerializeField] TMP_Text gameText;
    [SerializeField] Button yesButton;
    [SerializeField] Button noButton;
    
    [SerializeField] GameObject revealPanel;
    [SerializeField] TMP_Text revealText;
    [SerializeField] Image revealImg;

    [SerializeField] State startState;
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

    public void traverseParent() {
        if(currentStateIsNull()) return;
        currentState = currentState.getParent();
        updateQuestionText();
    }
    
    public void playAgain() {
        currentState = startState;
        revealPanel.SetActive(false);
        updateQuestionText();
    }

    void updateQuestionText() {
        if(currentStateIsNull()) return;
        
        if (currentState.isLeaf()) {
            Pokemon guessedPokemon = currentState.getPokemon();
            if(guessedPokemon != null) {
                gameText.text = currentState.getPokemon().getName();
                showAndUpdateRevealUI(guessedPokemon);
            }
        }
        else {
            gameText.text = currentState.getQuestionText();
        }

        unselectButton();
    }

    private bool currentStateIsNull() {
        return currentState == null;
    }

    private void showAndUpdateRevealUI(Pokemon pokemon) {
        revealPanel.SetActive(true);
        revealText.text = pokemon.toString();
        revealImg.overrideSprite = pokemon.getSprite();
    }

    private void unselectButton() {
        EventSystem.current.SetSelectedGameObject(null);
    }
}