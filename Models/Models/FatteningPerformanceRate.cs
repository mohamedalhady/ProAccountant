using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models
{
    public class FatteningPerformanceRate
    {
        [Key]
        public int Age { get; set; } // العمر
        public float Weight { get; set; }//الوزن
        public float WeightGain { get; set; }// الزياده فى الوزن
        public float DailyFeedConsumption { get; set; }// استهلاك العلف اليومي
        public float CumulativeFeedConsumption { get; set; }//تراكمي اسنهلاك العلف
        public float ConversionFactor { get; set; }// معامل التحويل
    }
}
