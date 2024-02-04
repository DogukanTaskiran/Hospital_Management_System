﻿using System.ComponentModel.DataAnnotations;

namespace Entities.DTOs{
	public class ApplicationUserDTO
	{
		[Required(ErrorMessage = "Name is required")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Surname is required")]
		public string Surname { get; set; }

		[Required(ErrorMessage = "Phone number is required")]
		public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Age number is required")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Height number is required")]
        public int Height { get; set; }

        [Required(ErrorMessage = "Weight number is required")]
        public int Weight { get; set; }

        [Required(ErrorMessage = "Address is required")]
		public string Address { get; set; }

		[Required(ErrorMessage = "Gender is required")]
		public string Gender { get; set; }

		[Required(ErrorMessage = "Blood type is required")]
		public string BloodType { get; set; }

		[Required(ErrorMessage = "Email is required")]
		[EmailAddress(ErrorMessage = "Invalid email address")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Password is required")]
		[DataType(DataType.Password)]
		public string Password { get; set; }

		[Required(ErrorMessage = "Confirm password is required")]
		[DataType(DataType.Password)]
		[Compare("Password", ErrorMessage = "Passwords do not match")]
		public string ConfirmPassword { get; set; }
	}
}