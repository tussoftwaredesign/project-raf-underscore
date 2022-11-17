using System;
using System.Collections;
using System.Collections.Generic;
using Nutritionix;
using UnityEditor.Search;
using UnityEngine;

namespace Nutritionix
{
    public class NutritionixTester : MonoBehaviour {

        [SerializeField]
        private string query = "chicken";

        public void Start()
        {
            Debug.Log("Start");

            GetNutritionixFoodRequest request =
                (new GameObject("NutritionixRequest")).AddComponent<GetNutritionixFoodRequest>();

            request.GetFood();
        }

    }
}