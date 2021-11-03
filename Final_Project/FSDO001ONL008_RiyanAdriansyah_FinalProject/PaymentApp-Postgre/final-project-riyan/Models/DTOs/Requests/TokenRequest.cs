using System.ComponentModel.DataAnnotations;

namespace final_project_riyan.Models.DTOs.Requests
{
    public class TokenRequest
    {
        [Required]
        public string Token {get;set;}

        [Required]
        public string RefreshToken {get;set;}
    }
}