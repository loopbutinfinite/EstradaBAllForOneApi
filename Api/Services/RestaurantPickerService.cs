using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Services
{
    public class RestaurantPickerService
    {
        int randomIndianRestaurant = 0;
        int randomGreekRestaurant = 0;
        int randomKoreanRestaurant = 0;
        public string RestaurantPicker(string userCategory)
        {
            userCategory.ToLower();
            if (userCategory == "indian")
            {
                Random indianRestaurants = new Random();
                randomIndianRestaurant = indianRestaurants.Next(1, 11);
                switch (randomIndianRestaurant)
                {
                    case 1:
                        {
                            return "Swagat Indian Cuisine";
                        }
                    case 2:
                        {
                            return "Tandoori Nites";
                        }
                    case 3:
                        {
                            return "Maharaja Indian Cuisine";
                        }
                    case 4:
                        {
                            return "Chaat of India";
                        }
                    case 5:
                        {
                            return "Tikka Masala Indian Cuisine";
                        }
                    case 6:
                        {
                            return "Shan-E-Punjab";
                        }
                    case 7:
                        {
                            return "Amarvillas Indian Restaurant & Bar";
                        }
                    case 8:
                        {
                            return "Taste of India";
                        }
                    case 9:
                        {
                            return "Tandoori Pizza";
                        }
                    case 10:
                        {
                            return "Desi Grill";
                        }
                    default:
                        break;
                }
            }
            else if (userCategory == "greek")
            {
                Random greekRestaurants = new Random();
                randomGreekRestaurant = greekRestaurants.Next(1, 11);
                switch (randomGreekRestaurant)
                {
                    case 1:
                        {
                            return "Go Falafel Greek Food";
                        }
                    case 2:
                        {
                            return "Papapavlo's Bistro & Bar";
                        }
                    case 3:
                        {
                            return "Kabob & Gyro House";
                        }
                    case 4:
                        {
                            return "Yasoo Yani Restaurant";
                        }
                    case 5:
                        {
                            return "Nick the Greek";
                        }
                    case 6:
                        {
                            return "Sugar Mediterranean Bistro";
                        }
                    case 7:
                        {
                            return "The House of Pita";
                        }
                    case 8:
                        {
                            return "St. Basil's Greek Food";
                        }
                    case 9:
                        {
                            return "Manny's California Fresh Cafe";
                        }
                    case 10:
                        {
                            return "Garlic Brothers";
                        }
                    default:
                        break;
                }
            }
            else if (userCategory == "korean")
            {
                Random koreanRestaurants = new Random();
                randomKoreanRestaurant = koreanRestaurants.Next(1, 11);
                switch (randomKoreanRestaurant)
                {
                    case 1:
                        {
                            return "Seoul Soon Dubu";
                        }
                    case 2:
                        {
                            return "K-Town Korean BBQ & Hot Pot";
                        }
                    case 3:
                        {
                            return "Yogi Korean BBQ";
                        }
                    case 4:
                        {
                            return "Bonchon";
                        }
                    case 5:
                        {
                            return "Tasty Pot";
                        }
                    case 6:
                        {
                            return "Mama's Poke & Korean BBQ";
                        }
                    case 7:
                        {
                            return "L&L Hawaiian BBQ";
                        }
                    case 8:
                        {
                            return "Seoul Grill";
                        }
                    case 9:
                        {
                            return "Sharetea";
                        }
                    case 10:
                        {
                            return "Rice Box";
                        }
                    default:
                        break;
                }
            }
            return "Invalid Category. Please type in lowercase and choose between korean, indian, or greek.";
        }
    }
}