﻿namespace Portfolio.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; } = string.Empty;
        public string Date { get; set; }
    }
}
