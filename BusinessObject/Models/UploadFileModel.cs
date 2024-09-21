using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject.Models
{
	public class UploadFileModel
	{
		[Required(ErrorMessage = "Choose one file")]
		[DataType(DataType.Upload)]
		[FileExtensions(Extensions = "png, jpg, jpeg, gif")]
		[Display(Name = "Choose one file")]
		public IFormFile FileUpload { get; set; }

	}
}
