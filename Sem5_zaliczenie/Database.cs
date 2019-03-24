using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Sem5_zaliczenie
{
    public class Database:DbContext
    {
        public Database() : base("name=SupaApp"){}

        public DbSet<User> Users { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Contact> Contacts { get; set; }

    }

    [Table("Users")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Username { get; set;}
        public string Password { get; set; }
        public int SecurityLevel { get; set; }
        public DateTime LastLogin { get; set; }

    }

    [Table("Patients")]
    public class Patient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }

    [Table("Contacts")]
    public class Contact
    {
        [Key]
        public int PatientId { get; set; }
        public string ContactEntry { get; set; }
    }
}