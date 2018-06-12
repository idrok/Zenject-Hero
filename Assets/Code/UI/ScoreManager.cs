﻿using UnityEngine;
using UnityEngine.UI;

namespace Code
{
    public class ScoreManager : MonoBehaviour
    {
        private Text _scoreTxt;
        private int Score { get; set; }

        private void Start()
        {
            _scoreTxt = GetComponent<Text>();
            _scoreTxt.text = "0";
        }

        public void UpdateScore(int scorePoints)
        {
            Score += scorePoints;
            _scoreTxt.text = Score.ToString();
        }
    }
}