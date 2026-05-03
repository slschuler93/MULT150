using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTimer : MonoBehaviour
{
    public class LevelTimer : MonoBehaviour
    {
        public Text timerText;

        private float elapsedTime = 0f;
        private bool timerRunning = true;

        // Goal tracking
        private bool blueDone = false;
        private bool greenDone = false;
        private bool redDone = false;
        private bool orangeDone = false;

        private int chaosBallsRequired = 5;
        private int chaosBallsCompleted = 0;

        void Update()
        {
            if (timerRunning)
            {
                elapsedTime += Time.deltaTime;
                UpdateUI();
            }
        }

        void UpdateUI()
        {
            float minutes = Mathf.FloorToInt(elapsedTime / 60);
            float seconds = Mathf.FloorToInt(elapsedTime % 60);

            timerText.text = minutes.ToString("00") + ":" + seconds.ToString("00");
        }

        // Called by goals
        public void CompleteGoal(string color)
        {
            switch (color)
            {
                case "Blue": blueDone = true; break;
                case "Green": greenDone = true; break;
                case "Red": redDone = true; break;
                case "Orange": orangeDone = true; break;
            }

            CheckIfFinished();
        }

        // Called by chaos balls
        public void CompleteChaosBall()
        {
            chaosBallsCompleted++;
            CheckIfFinished();
        }

        void CheckIfFinished()
        {
            if (blueDone && greenDone && redDone && orangeDone &&
                chaosBallsCompleted >= chaosBallsRequired)
            {
                timerRunning = false;
                Debug.Log("Finished! Time: " + timerText.text);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
