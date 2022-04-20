using System.ComponentModel.DataAnnotations;

namespace MvcStudent.Models
{
    public class student
    {

        public int Id { get; set; }
        [Display(Name = "名字")]
        [StringLength(300)]
       // [Column(TypeName ="decimal(18,2)")]
        public string Name { get; set; }
        [StringLength(1)]
        [Display(Name = "性别")]
        public string Gender { get; set; }
        [Display(Name = "年龄")]
        public int Age { get; set; }
        [Display(Name = "生日")]
        public DateTime Birthday { get; set; }
        [Display(Name = "电话")]
        public string Mobile { get; set; }
        [Display(Name = "体温")]
        public int Temperature { get; set; }
        [Display(Name = "登记日期")]
        public DateTime Tbrq { get; set; }




    }
}
