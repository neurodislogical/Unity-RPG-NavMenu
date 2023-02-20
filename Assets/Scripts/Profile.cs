using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UI;

namespace ProjectRPG
{
    public class Profile : MonoBehaviour
    {
        public TextMeshProUGUI displayPlayerName;

        public void Awake()
        {
            displayPlayerName.text = Player.player.playerName;
        }
    }
}