// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using UnityEngine;

public class AltMeasure
    {
        [JsonProperty("serving_weight", NullValueHandling = NullValueHandling.Ignore)]
        public double? ServingWeight;

        [JsonProperty("measure", NullValueHandling = NullValueHandling.Ignore)]
        public string Measure;

        [JsonProperty("seq", NullValueHandling = NullValueHandling.Ignore)]
        public int? Seq;

        [JsonProperty("qty", NullValueHandling = NullValueHandling.Ignore)]
        public int? Qty;
    }

    public class Food
    {
        [JsonProperty("food_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FoodName;

        [JsonProperty("brand_name", NullValueHandling = NullValueHandling.Ignore)]
        public object BrandName;

        [JsonProperty("serving_qty", NullValueHandling = NullValueHandling.Ignore)]
        public int? ServingQty;

        [JsonProperty("serving_unit", NullValueHandling = NullValueHandling.Ignore)]
        public string ServingUnit;

        [JsonProperty("serving_weight_grams", NullValueHandling = NullValueHandling.Ignore)]
        public int? ServingWeightGrams;

        [JsonProperty("nf_calories", NullValueHandling = NullValueHandling.Ignore)]
        public int? NfCalories;

        [JsonProperty("nf_total_fat", NullValueHandling = NullValueHandling.Ignore)]
        public double? NfTotalFat;

        [JsonProperty("nf_saturated_fat", NullValueHandling = NullValueHandling.Ignore)]
        public double? NfSaturatedFat;

        [JsonProperty("nf_cholesterol", NullValueHandling = NullValueHandling.Ignore)]
        public double? NfCholesterol;

        [JsonProperty("nf_sodium", NullValueHandling = NullValueHandling.Ignore)]
        public double? NfSodium;

        [JsonProperty("nf_total_carbohydrate", NullValueHandling = NullValueHandling.Ignore)]
        public double? NfTotalCarbohydrate;

        [JsonProperty("nf_dietary_fiber", NullValueHandling = NullValueHandling.Ignore)]
        public int? NfDietaryFiber;

        [JsonProperty("nf_sugars", NullValueHandling = NullValueHandling.Ignore)]
        public double? NfSugars;

        [JsonProperty("nf_protein", NullValueHandling = NullValueHandling.Ignore)]
        public double? NfProtein;

        [JsonProperty("nf_potassium", NullValueHandling = NullValueHandling.Ignore)]
        public double? NfPotassium;

        [JsonProperty("nf_p", NullValueHandling = NullValueHandling.Ignore)]
        public double? NfP;

        [JsonProperty("full_nutrients", NullValueHandling = NullValueHandling.Ignore)]
        public List<FullNutrient> FullNutrients;

        [JsonProperty("nix_brand_name", NullValueHandling = NullValueHandling.Ignore)]
        public object NixBrandName;

        [JsonProperty("nix_brand_id", NullValueHandling = NullValueHandling.Ignore)]
        public object NixBrandId;

        [JsonProperty("nix_item_name", NullValueHandling = NullValueHandling.Ignore)]
        public object NixItemName;

        [JsonProperty("nix_item_id", NullValueHandling = NullValueHandling.Ignore)]
        public object NixItemId;

        [JsonProperty("upc", NullValueHandling = NullValueHandling.Ignore)]
        public object Upc;

        [JsonProperty("consumed_at", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? ConsumedAt;

        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        public Metadata Metadata;

        [JsonProperty("source", NullValueHandling = NullValueHandling.Ignore)]
        public int? Source;

        [JsonProperty("ndb_no", NullValueHandling = NullValueHandling.Ignore)]
        public int? NdbNo;

        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public Tags Tags;

        [JsonProperty("alt_measures", NullValueHandling = NullValueHandling.Ignore)]
        public List<AltMeasure> AltMeasures;

        [JsonProperty("lat", NullValueHandling = NullValueHandling.Ignore)]
        public object Lat;

        [JsonProperty("lng", NullValueHandling = NullValueHandling.Ignore)]
        public object Lng;

        [JsonProperty("meal_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? MealType;

        [JsonProperty("photo", NullValueHandling = NullValueHandling.Ignore)]
        public Photo Photo;

        [JsonProperty("sub_recipe", NullValueHandling = NullValueHandling.Ignore)]
        public object SubRecipe;

        [JsonProperty("class_code", NullValueHandling = NullValueHandling.Ignore)]
        public object ClassCode;

        [JsonProperty("brick_code", NullValueHandling = NullValueHandling.Ignore)]
        public object BrickCode;

        [JsonProperty("tag_id", NullValueHandling = NullValueHandling.Ignore)]
        public object TagId;
    }

    public class FullNutrient
    {
        [JsonProperty("attr_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? AttrId;

        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public double? Value;
    }

    public class Metadata
    {
        [JsonProperty("is_raw_food", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsRawFood;
    }

    public class Photo
    {
        [JsonProperty("thumb", NullValueHandling = NullValueHandling.Ignore)]
        public string Thumb;

        [JsonProperty("highres", NullValueHandling = NullValueHandling.Ignore)]
        public string Highres;

        [JsonProperty("is_user_uploaded", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsUserUploaded;
    }

    public class Tags
    {
        [JsonProperty("item", NullValueHandling = NullValueHandling.Ignore)]
        public string Item;

        [JsonProperty("measure", NullValueHandling = NullValueHandling.Ignore)]
        public string Measure;

        [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
        public string Quantity;

        [JsonProperty("food_group", NullValueHandling = NullValueHandling.Ignore)]
        public int? FoodGroup;

        [JsonProperty("tag_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? TagId;
    }

    public class FoodDataController
    {
        [JsonProperty("foods", NullValueHandling = NullValueHandling.Ignore)]
            
        public List<Food> Foods;
            
        public static FoodDataController FromJson(string json) => JsonConvert.DeserializeObject<FoodDataController>(json, Converter.Settings);
    }

    public static partial class Serialize
    {
        public static string ToJson(this FoodDataController self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

