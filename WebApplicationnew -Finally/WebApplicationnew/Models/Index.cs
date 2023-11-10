﻿using System.ComponentModel.DataAnnotations;

public class Index
{
    [Key]
    public int Id { get; set; }

    public string Title { get; set; }

    public string Author { get; set; }

    public string Category { get; set; }

    public string ImageUrl { get; set; }
    public string Description { get; set; }
}
