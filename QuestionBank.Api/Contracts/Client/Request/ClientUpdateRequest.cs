﻿using System.ComponentModel.DataAnnotations;

namespace QuestionBank.Api.Contracts.Client.Request
{
    public record ClientRequest // why record when you compare class it compare refernce but on record you can compare values
    {
        public ClientRequest()
        {
            ApiClaims = new List<long>();
        }
        [Required]
        [MinLength(3)]
        public string ClientName { get; set; }
        [Required]
        [MinLength(3)]
        public string ClientId { get; set; }
        [Required]
        [MinLength(8)]
        public string ClientSecret { get; set; }
        [Required]
        [MinLength(3)]
        public string Description { get; set; }
        [Required]
        [Range(3600, int.MaxValue)]//unit second -  minimum value 1 minute
        public int AccessTokenLifeTime { get; set; }
        [Required]
        [Range(3600, int.MaxValue)]//unit second - value 1 minute
        public int RefreshTokenLifeTime { get; set; }
        public List<long> ApiClaims { get;  set; } 
    }
}
