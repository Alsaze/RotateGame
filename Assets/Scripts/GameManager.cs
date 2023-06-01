using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{ 
   [SerializeField] private Text timerText;
   private float _timeLeft;

   [SerializeField] private Text lvlText;
   private int _lvl;
   
   private void UpdateTimeText()
   {
      float minutes = Mathf.FloorToInt(_timeLeft / 60);
      float seconds = Mathf.FloorToInt(_timeLeft % 60);
      timerText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
   }
   private void Update()
   {
      _timeLeft += Time.deltaTime;
      UpdateTimeText();

      lvlText.text = _lvl.ToString();
   }

   public void Lose()
   {
      Debug.Log("You Lose");
      Time.timeScale = 0;
   }

   public void Win()
   {
      Debug.Log("You Win");
      Time.timeScale = 0;
      _lvl++;
   }
}