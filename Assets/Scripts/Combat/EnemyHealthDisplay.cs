using UnityEngine;
using UnityEngine.UI;
using RPG.Attributes;
using System;

namespace RPG.Combat
{
    public class EnemyHealthDisplay : MonoBehaviour
    {
        Fighter fighter;

        private void Awake()
        {
            fighter = GameObject.FindWithTag("Player").GetComponent<Fighter>();
        }

        private void Update()
        {
            if (fighter.GetTarget() == null)
            {
                GetComponent<Text>().text = "N/A";
                return;
            }
            Health health = fighter.GetTarget();
            GetComponent<Text>().text = String.Format("{0:0.0}/{1:0}", health.GetHealth(), health.GetMaxHealth());
            // GetComponent<Text>().text = string.Format("{0:0.0}%", health.GetPercentage());
        }
    }
}