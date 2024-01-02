using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace MVC_TUTORIAL_5_12_23.Models
{
    public class Traderecord
    {
        [Key]
        public int ID { get; set; }

        public DateTime DATE { get; set; } = DateTime.Now;

        public int INDEX { get; set; }

        public int PRICE { get; set; }

        public string BORS { get; set; }

        public int SL {  get; set; }

        public int PROFIT { get; set; }

        public int TOTAL {  get; set; }
    }
}
