﻿
namespace UserManagementMicroservice.Entities
{
    public class Rating
    {
       
        public int Id { get; set; }

        public int MovieId { get; set; }

        public int UserId { get; set; }

        public int Score { get; set; }
    }
}
