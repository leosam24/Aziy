using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour
{
    public List<QuestionsAndAnswers> QnA;
    public GameObject[] options;
    public int currentQuestion;

    public GameObject Quizpanel;
    public GameObject Winpanel;
    public GameObject Losepanel;
    

    public MoveAttack Move;
    public MoveAttackEnemy MoveE;

    

    public TextMeshProUGUI QuestionTxt;
    public TextMeshProUGUI ScoreTxtWin;
    public TextMeshProUGUI ScoreTxtLose;

    int totalQuestions = 0;
    public int score;



    private void Start()
    {
        totalQuestions = QnA.Count;
        Winpanel.SetActive(false);
        Losepanel.SetActive(false);
        generateQuestions();

        

    }

    public void retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void gameOver()
    {
        if(score >= 3)
        {
            Quizpanel.SetActive(false);
            Winpanel.SetActive(true);
            ScoreTxtWin.text = score + "/" + totalQuestions;
            
            
        }
        else
        {
            Quizpanel.SetActive(false);
            Losepanel.SetActive(true);
            ScoreTxtLose.text = score + "/" + totalQuestions;
            Move.knightDie();
            
        }
        
        

    }

    public void correct()
    {
        score += 1;
        QnA.RemoveAt(currentQuestion);
        generateQuestions();
        Move.knightAttack();

    }

    public void wrong()
    {
        QnA.RemoveAt(currentQuestion);
        generateQuestions();
        MoveE.evilBugAttack();

    }

    void SetAnswers()
    {
        for (int i = 0; i < options.Length; i++)
        {
            options[i].GetComponent<AnswerScript>().isCorrect = false;
            options[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = QnA[currentQuestion].Answers[i];

            if(QnA[currentQuestion].correctAnswer == i + 1)
            {
                options[i].GetComponent<AnswerScript>().isCorrect = true;
            }

        }
    }

    void generateQuestions()
    {
        if(QnA.Count > 0)
        {
            //currentQuestion = Random.Range(0, QnA.Count);
            currentQuestion = (currentQuestion + 1) % QnA.Count;




            QuestionTxt.text = QnA[currentQuestion].Questions;
            SetAnswers();
        }
        else
        {
            Debug.Log("Out of Questions");

            Invoke("gameOver", 3);
        }
             
        
    }
    
    
    
}
