﻿using System.ComponentModel.DataAnnotations;

public class UserRegisterModel
{
    public int? UserID { get; set; }

    [Required(ErrorMessage = "Username is required.")]
    public string UserName { get; set; }

    [Required(ErrorMessage = "Password is required.")]
    public string Password { get; set; }

    [Required(ErrorMessage = "Email is required.")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Mobile Number is required.")]
    public string MobileNo { get; set; }
}