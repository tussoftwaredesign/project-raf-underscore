using System;
using System.Collections;
using System.Collections.Generic;
using Nutritionix;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

 
    public class NutritionixTester : MonoBehaviour {

       
        private GetNutritionixFoodRequest request;
        
        [Header("Nutritionix")]
        [TextArea(3, 10)]
        public string query = "1 glass of water";
        
        [Header("Text Mesh Pro")]
        public TextMeshProUGUI text;

        [Header("Food Data Object")]
        public Food FoodObject;
        
        
        public void Start()
        {
            request = (new GameObject("NutritionixRequest")).AddComponent<GetNutritionixFoodRequest>();
        }

        public void GetInformation()
        {
            request.GetFood(query, text);
            
            FoodObject = request.food;
        }
    }
