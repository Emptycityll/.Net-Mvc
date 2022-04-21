using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcStudent.Models
{
    public class student
    {

        public int Id { get; set; }//id
        [Display(Name = "名字")]
        [StringLength(300)]
        // [Column(TypeName ="decimal(18,2)")]
        public string? Name { get; set; }//姓名（长度不超300）
        [StringLength(1)]
        [Display(Name = "性别")]
        public string? Gender { get; set; }//性别(长度为1)
        [Display(Name = "年龄")]
        [Range(1,200)]
        public int Age { get; set; }//年龄（1-200）
        [Display(Name = "出生日期")]
        [DataType(DataType.Date)]
        public DateTime Birthday { get; set; }//出生日期
        [Display(Name = "电话")]
        [StringLength(13)]
        [RegularExpression(@"^\d+$", ErrorMessage = "请输入正确的电话号码：")]
        [Required]
        
        public string? Mobile { get; set; }//电话（13位）
        [Display(Name = "体温")]
       // [Column(TypeName = "double(2,1)")]
        [Range(30,50)]
        public int Temperature { get; set; }//体温（30-50）
        [Display(Name = "登记日期")]
        [DataType(DataType.Date)]
        public DateTime Tbrq { get; set; }//登记日期




    }
}
