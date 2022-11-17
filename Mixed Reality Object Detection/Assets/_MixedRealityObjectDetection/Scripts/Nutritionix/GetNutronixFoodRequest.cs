using System;
using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Nutritionix;
using UnityEngine;
using UnityEngine.Networking;

public class GetNutritionixFoodRequest : MonoBehaviour
{
    private readonly string _id = "20cc37ae";
    private readonly string _key = "b38f89ed44a520302234f5b83853b4c9";
    private readonly string _url = "https://trackapi.nutritionix.com/v2/natural/nutrients";
    private readonly string _timezone = "US/Eastern";
    private readonly string _locale = "en_US";
    private readonly string _contentType = "application/json";

    FoodDataController data;

    public class GetFoodRequest
    {
        public string query { get; set; }
        public string timezone { get; set; } 
    }
    
    public void GetFood()
    {
        StartCoroutine(MakeFoodRequest());
    }

    IEnumerator MakeFoodRequest()
    {
        var bodyRequest = new GetFoodRequest()
        {
            query = "1 cup of milk",
            timezone = _timezone
        };

        var body = JsonConvert.SerializeObject(bodyRequest);
        var bytes = Encoding.UTF8.GetBytes(body);

        using (var request = new UnityWebRequest(_url, "POST"))
        {
            request.uploadHandler = new UploadHandlerRaw(bytes);
            request.downloadHandler = new DownloadHandlerBuffer();

            request.SetRequestHeader("Content-Type", _contentType);
            request.SetRequestHeader("x-app-id", _id);
            request.SetRequestHeader("x-app-key", _key);
            request.SetRequestHeader("x-remote-user-id", "0");

            yield return request.SendWebRequest();

            switch (request.result)
            {
                case UnityWebRequest.Result.ConnectionError:
                case UnityWebRequest.Result.DataProcessingError:
                    Debug.Log(request.error);
                    break;
                case UnityWebRequest.Result.ProtocolError:
                    Debug.Log(request.error);
                    break;
                case UnityWebRequest.Result.Success:
                    Debug.Log(request.downloadHandler.text); 
                    
                    FoodDataController data  = FoodDataController.FromJson (request.downloadHandler.text);
                    
                    foreach (var item in data.Foods)
                    {
                        Debug.Log(item.FoodName);
                    }
                    break;
            }
        }
    }
}