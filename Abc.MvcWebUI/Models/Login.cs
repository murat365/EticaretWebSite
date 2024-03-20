﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Abc.MvcWebUI.Models
{
    public class Login
    {

        [Required]
        [DisplayName("Kullanıcı Adı")]
        public string Username { get; set; }

        [Required]
        [DisplayName("Şifre")]
        public string Password { get; set; }

       
        [DisplayName("Beni Hatırla")]
        public bool RememberMe { get; set; }
    }
}