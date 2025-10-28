using NUnit.Framework;
using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using TMPro;

public class QuizManager : MonoBehaviour
{
    public System.Collections.Generic.List<QuestionAndAnswers> QnA;
    public GameObject[] options;
    public int currentQuestion;

    public UnityEngine.UI.Text QuestionTxt;

    private void Start()
    {
        generateQuestion();
    }


    public void correct()
    {
        generateQuestion();
        QnA.RemoveAt(currentQuestion);
    }


    void SetAnswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AnswerSciript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = QnA[currentQuestion].Answers[i];

            if (QnA[currentQuestion].CorrectAnswer == i + 1)
            {
                options[i].GetComponent<AnswerSciript>().isCorrect = true;
            }
        }
    }


    void generateQuestion()
    {
        currentQuestion = Random.Range(0, QnA.Count);

        QuestionTxt.text = QnA[currentQuestion].Question;
        SetAnswers();

    }
}
