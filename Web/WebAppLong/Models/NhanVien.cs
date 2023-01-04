using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppLong.Models;

public partial class NhanVien
{
    [DisplayName("Mã nhân viên")]
    [Required(AllowEmptyStrings = false, ErrorMessage = "Vui lòng nhập mã nhân viên")]
    public string Id { get; set; } = null!;

    [DisplayName("Tên nhân viên")]
    [Required(AllowEmptyStrings = false, ErrorMessage = "Vui lòng nhập tên nhân viên")]
    public string UserName { get; set; } = null!;

    [DisplayName("Mật khẩu")]
	public string? Password { get; set; }

    [DisplayName("Email")]
    [EmailAddress(ErrorMessage = "Định dạng email sai")]
    public string? Email { get; set; }

    [DisplayName("Số điện thoại")]
    [Phone(ErrorMessage = "Định dạng số điện thoại sai")]
    public string? Tel { get; set; }

    [DisplayName("Không hiển thị")]
    public bool? Disabled { get; set; }

    [NotMapped]
    [DisplayName("Nhập lại mật khẩu")]
    //[Compare(otherProperty: "validatePassword", ErrorMessage = "Mật khẩu không khớp")]
    public string? ConfirmPassword { get; set; }

    //public string validatePassword
    //{
    //    get
    //    {
    //        //Do Some calculations here 
    //        return this.Password;
    //    }
    //}

}
