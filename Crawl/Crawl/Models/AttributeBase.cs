﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;

namespace Crawl.Models
{
    public class AttributeBase
    {
        // The speed of the character, impacts movement, and initiative
        public int Speed { get; set; }

        // The defense score, to be used for defending against attacks
        public int Defense { get; set; }

        // The Attack score to be used when attacking
        public int Attack { get; set; }

        // Current Health which is always at or below MaxHealth
        public int CurrentHealth { get; set; }

        // The highest value health can go
        public int MaxHealth { get; set; }

        // Helper to combine the attributes into a single line, to make it easier to display the item as a string
        public string FormatOutput()
        {
            var myReturn = "Implement";
            return myReturn.Trim();
        }

        // Construtor sets defaults
        public AttributeBase()
        {
            SetDefaultValues();
        }

        // Defaults are all value 1, and then adjusted by scaling up
        private void SetDefaultValues()
        {
            Speed = 1;
            Defense = 1;
            Attack = 1;
            CurrentHealth = 1;
            MaxHealth = 1;
        }

        // Return attributebase based on a string as the constructor.
        public AttributeBase(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                SetDefaultValues();
                return;
            }

            var myAttributes = JsonConvert.DeserializeObject<AttributeBase>(data);

            Speed = myAttributes.Speed;
            Defense = myAttributes.Defense;
            Attack = myAttributes.Attack;
            CurrentHealth = myAttributes.CurrentHealth;
            MaxHealth = myAttributes.MaxHealth;
        }

        // Return a formated string of the datastruture
        public static string GetAttributeString (AttributeBase data)
        {
            var myString = (JObject)JToken.FromObject(data);

            return myString.ToString();
        }

        // Given a string of attributes, convert them to actual attributes
        public static AttributeBase GetAttributeFromString(string data)
        {
            AttributeBase myResult;

            // Convert the string to json object
            // convert the json object to the class
            // retun the class

            // make sure the object is properly formated json for the object type
            try
            {
                myResult = JsonConvert.DeserializeObject<AttributeBase>(data);
                return myResult;
            }

            catch (Exception)
            {
                // Failed, so fall through to the return of new.
                return new AttributeBase();
            }
        }
    }
}