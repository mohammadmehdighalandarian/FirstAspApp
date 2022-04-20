using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FirstApp.Models
{
    public class SendMessage
    {
        [Required(ErrorMessage = "اين فيلد اجباري است")]
        [MaxLength(15,ErrorMessage = "حداكثر تعداد حروف 15 است")]
        [MinLength(3,ErrorMessage = "حداقل تعداد حروف 3 است")]
        public string Name { get; set; }


        [Required(ErrorMessage = "اين فيلد اجباري است")]
        [MaxLength(15, ErrorMessage = "حداكثر تعداد حروف 15 است")]
        public string Message { get; set; }

        [Required(ErrorMessage = "اين فيلد اجباري است")]
        [EmailAddress(ErrorMessage = "لطفا ایمیل را به درستی وارد کنید")]
        public string Email { get; set; }

        [Required(ErrorMessage = "اين فيلد اجباري است")]
        public string Status { get; set; }

        public SelectList servises { get; set; }
    }
}
