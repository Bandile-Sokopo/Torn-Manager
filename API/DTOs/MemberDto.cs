using API.Dtos;
using System;

namespace API.DTOs
{
	public class MemberDto
	{
		public int Id { get; set; }
		public string? UserName { get; set; }
        public string? PhotoUrl { get; set; }
        public string KnownAs { get; set; }
		public DateTime Created { get; set; } = DateTime.UtcNow;
		public DateTime LastActive { get; set; }
		public string Gender { get; set; }
		public PhotoDto photo { get; set; }
	}
}
