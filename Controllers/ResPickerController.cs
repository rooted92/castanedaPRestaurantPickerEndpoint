//Pedro Castaneda
//10-26-2022
//Restaurant Picker - Endpoint
//Create an endpoint that calls a function which give user a random restaurant pick from a food category of their choice.
//Peer Review by; Ulises Ortega, the Endpoint requested me to selected 1 type of food and the recomended me a restaurant based on a randow fuction, it works prefect, very impress that you are already working it with the Json get;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using castanedaPRestaurantPickerEndpoint.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace castanedaPRestaurantPickerEndpoint.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ResPickerController : ControllerBase
    {
        Random r = new Random();
        int resPicked = 0;
        [HttpGet("Picker")]
        public string RestaurantPicker(RestaurantPickModel input)
        {   
            string result = "";
            List<string> european = new List<string>(){"German Guys", "Angelina's", "The Old Spaghetti Factory", "Strings Italian Cafe", "Midtown Creperie & Cafe", "Finnegan's Irish Pub & Restaurant", "Kabob and Gyro House", "La Boulangerie", "Go Falafel Greek Food", "Mezzo"};
            List<string> american = new List<string>(){"The Kitchen at StoneBrier", "Market Tavern", "Wildfire Public House", "The Well", "FED", "The Black Rabbit", "Cast Iron Trading", "Fat City Brew & BBQ", "Prime Table", "Nash & Tender"};
            List<string> asian = new List<string>(){"Pho Island", "Lotus Thai & Khmer Cuisines", "Spice it up!", "Jimmies Place", "Seoul Soon Dubu Tofu House", "Siamese Street Thai Restaurant", "Thai Me Up", "Mama's Pho & Sandwhiches", "Maroo Korean BBQ and Catering", "Saigon Bowl Noodle House"};
            List<string> latin = new List<string>(){"El Patio", "Cafe Platano Bar & Grill", "MasaLatina Latin American Kitchen", "Gladys Taqueria Y Pupuseria", "La Santaneca Pupuseria", "Streetzlan", "Reyes Pupuseria Y Taqueria", "Jalisco's Restaurant", "El Ranchito Restaurant", "El Comal Taco Truck"};
            if(input.foodType == "euro" || input.foodType == "european")
            {
                resPicked = r.Next(0, european.Count);
                result = $"We recommend: {european[resPicked]}";           
            }
            else if(input.foodType == "american")
            {
                resPicked = r.Next(0, american.Count);
                result = $"We recommend: {american[resPicked]}";
            }
            else if(input.foodType == "asian")
            {
                resPicked = r.Next(0, asian.Count);
                result = $"We recommend: {asian[resPicked]}";
            }
            else if(input.foodType == "latin")
            {
                resPicked = r.Next(0, latin.Count);
                result = $"We recommend: {latin[resPicked]}";
            }
            else
            {
                result = "Please enter: european, american, asian, or latin";
            }
            return result;
        }
    }
}