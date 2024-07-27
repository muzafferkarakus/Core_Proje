using System.ComponentModel.DataAnnotations;

namespace Core_Proje.Areas.User.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Adınızı Girin")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Soyadınızı Girin")]
        public string Surname { get; set; }
        [Required(ErrorMessage = "Resim dosyası yükleyin")]
        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "Kullanıcı Adını Girin")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Şifrenizi Girin")]
        public string Password { get; set; }
        [Required(ErrorMessage = "Şifreyi Tekrar Girin")]
        [Compare("Password", ErrorMessage = "Şifreler uyumlu değil")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "E-Posta Adresi Girin")]
        public string Mail { get; set; }
    }
}
