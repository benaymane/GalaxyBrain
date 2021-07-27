using UnityEngine;

[CreateAssetMenuAttribute(menuName = "QuestionText")]
public class Question : ScriptableObject {
    [TextArea(10, 14)][SerializeField] string questionText;

    public string getQuestionText() {
        return questionText;
    }
}

