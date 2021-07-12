using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class NumberWizard : MonoBehaviour {

    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;
    ArrayList alreadyGuessed = new ArrayList();

    // Use this for initialization
    void Start() {
        NextGuess();
    }

    void StartGame()
    {
        NextGuess();
    }

    void NextGuess() {
        guess = GenerateInteger(min, max);
        if (alreadyGuessed.Count > 0 && alreadyGuessed.Contains(guess) && guess!=max) {
            guess = guess + 1;
        }
        guessText.text = guess.ToString();
        alreadyGuessed.Add(guess);
    }

    // Update is called once per frame
    public void OnPressHigher()
    {
        min = guess;
        NextGuess();
    }
    public void OnPressLower()
    {
        max = guess;
        NextGuess();
    }

    int GenerateInteger(int min, int max) {
        return Random.Range(min, max);
    }
}
