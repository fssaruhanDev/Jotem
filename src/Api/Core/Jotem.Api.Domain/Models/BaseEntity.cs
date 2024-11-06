using System;
namespace Jotem.Api.Domain.Models
{
	public abstract class BaseEntity
	{
		public Guid ID { get; set; }
		public DateTime CreateDate { get; set; }
		public DateTime UpdateDate { get; set; }
		public Guid CreatedUserID { get; set; }
		public Guid UpdateUserID { get; set; }
    }
}

