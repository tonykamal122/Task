using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskSolution.Models
{
    public class Album
    {
        public int AlbumIndetifier { get; set; }
        public string? Title { get; set; }
        public DateTime CopyrightDate { get; set; }
        public decimal Price { get; set; }
        public string Duration { get; set; }
    }
}