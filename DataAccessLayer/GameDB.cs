namespace DataAccessLayer
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Linq;

    public class GameDB : DbContext
    {
        // Your context has been configured to use a 'GameDB' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'DataAccessLayer.GameDB' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'GameDB' 
        // connection string in the application configuration file.
        public GameDB()
            : base("name=GameDB")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Game> Games { get; set; }
    }
    [Table("Users")]
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        [MaxLength(128)]
        [MinLength(3)]
        public string Login { get; set; }
        [Required]
        [MaxLength(128)]
        [MinLength(7)]
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        [Required]
        public string Email { get; set; }
        public ICollection<Game> Games { get; set; }
        public byte[] ImageFile { get; set; }
    }
    public class Game
    {
        [Key]
        public int GameId { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public int Score { get; set; }
        public User User { get; set; }
        [ForeignKey("User")]
        public int User_UserId { get; set; }

    }
}