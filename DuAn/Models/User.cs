﻿namespace DuAn.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Gmail { get; set; }
        public string LinkAnh { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Guid RoleId { get; set; }

        public int Status { get; set; }


        public virtual Role Role { get; set; }
        public virtual ICollection<Bill> Bill { get; set; }
        public virtual Cart Cart { get; set; }
  

    }
}
