﻿using MutualAid.Data.Entities;
using MutualAidRefactorEFCore.Data.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MutualAid.Data.DTO
{
    [Serializable]
    public class RequestDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public UserDto User { get; set; }
        public bool IsAccepted { get; set; }
        public DateTime Date { get; set; }

        //toiletries 
        public string ToiletPaper { get; set; }
        public string PaperTowels { get; set; }
        public string HandSoap { get; set; }
        public string Shampoo { get; set; }
        public string Conditioner { get; set; }
        public string Toothpaste { get; set; }
        public string Disinfectant { get; set; }

        //food
        public string Dairy { get; set; }
        public string Bread { get; set; }
        public string Produce { get; set; }
        public string CannedFood { get; set; }
        public string Meat { get; set; }
        public string Seafood { get; set; }
        public string Cereal { get; set; }
        public string Pantry { get; set; }

        //allergies
        public string Allergens { get; set; }
    }
}
