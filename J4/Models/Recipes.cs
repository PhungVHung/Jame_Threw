using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace J4.Models
{
    public class Recipes
    {
        public Recipes()
        {
            this.role = Role.Free;
        }
        public int Id { get; set; }
        public string Image_Food { get; set; }

        public string Name_Food { get; set; }

        public string Resources_prepare { get; set; }
        public string Resources1 { get; set; }
        public string Resources2 { get; set; }
        public string Resources3 { get; set; }
        public string Resources4 { get; set; }
        public string Resources5 { get; set; }
        public string Resources6 { get; set; }

        public string Resources7 { get; set; }

        public string Step1 { get; set; }
        public string Recipe_image1 { get; set; }
        public string Step2 { get; set; }
        public string Recipe_image2 { get; set; }
        public string Step3 { get; set; }
        public string Recipe_image3 { get; set; }
        public string Step4 { get; set; }
        public string Recipe_image4 { get; set; }
        public string Step5 { get; set; }
        public string Recipe_image5 { get; set; }
        public string Step6 { get; set; }
        public string Recipe_image6 { get; set; }


        public Role role { get; set; }
        public string Image_Practice { get; set; }
        public string Image_Practice2 { get; set; }
        public string Image_Practice3 { get; set; }
        
            

    }
    public enum Role
    {
        Free = 0,
        Vip = 1
    }
}
