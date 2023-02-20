using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.VisualScripting;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

namespace ProjectRPG
{
    public class Player : Character
    {
        public static Player player;
        
        public TMP_InputField inputField;
        public string playerName;
        
        //public GameObject inputField;
        //public GameObject displayName;

        //Singleton instance of player name (else delete duplicates)
        private void Awake()
        {
            if (player == null)
            {
                player = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }

        //SetName Function

        public void SetPlayerName()
        {
            playerName = inputField.text;

            //SceneManager.LoadSceneAsync(2);
        }

        //public void DisplayPlayerName()
        //{
        //    displayName.GetComponent<Text>().text = playerName;
        //}
        

    }
}