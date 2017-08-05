using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace CoreEcommerce.Models
{
    public class User
    {
        [Key]
        public int userId { get; set; }

        [Required(ErrorMessage = "Email is required.")]
        [StringLength(96, ErrorMessage ="Email cannot be longer than 96 characters.")]
        public string email { get; set; }

        [StringLength(64, ErrorMessage = "First name cannot be longer than 64 characters.")]
        public string firstName { get; set; }

        [StringLength(64, ErrorMessage = "Last name cannot be longer than 64 characters.")]
        public string lastName { get; set; }

        [StringLength(64, ErrorMessage = "Shipping address 1 cannot be longer than 64 characters.")]
        public string shippingAddress1 { get; set; }

        [StringLength(64, ErrorMessage = "Shipping address 2 cannot be longer than 64 characters.")]
        public string shippingAddress2 { get; set; }

        [StringLength(32, ErrorMessage = "Shipping city cannot be longer than 32 characters.")]
        public string shippingCity { get; set; }

        [StringLength(32, ErrorMessage = "Shipping state cannot be longer than 32 characters.")]
        public string shippingState { get; set; }

        [Range(0,9999999999, ErrorMessage = "Zip must be between 0 and 9999999999.")]
        public int shippingZip { get; set; }

        [StringLength(2, ErrorMessage = "Shipping country cannot be longer than 2 characters.")]
        public string shippingCountry { get; set; }

        [StringLength(64, ErrorMessage = "Billing first name cannot be longer than 64 characters.")]
        public string billingFirstName { get; set; }

        [StringLength(64, ErrorMessage = "Billing last name cannot be longer than 64 characters.")]
        public string billingLastName { get; set; }

        [StringLength(64, ErrorMessage = "Billing address 1 cannot be longer than 64 characters.")]
        public string billingAddress1 { get; set; }

        [StringLength(64, ErrorMessage = "Billing address 2 cannot be longer than 64 characters.")]
        public string billingAddress2 { get; set; }

        [StringLength(32, ErrorMessage = "Billing city cannot be longer than 32 characters.")]
        public string billingCity { get; set; }

        [StringLength(32, ErrorMessage = "Billing state cannot be longer than 32 characters.")]
        public string billingState { get; set; }

        [Range(0,9999999999, ErrorMessage = "Billing zip must be between 0 and 9999999999.")]
        public int billingZip { get; set; }

        [StringLength(2, ErrorMessage = "Billing country cannot be longer than 2 characters.")]
        public string billingCountry { get; set; }

        [Range(0, 999999999999999999, ErrorMessage = "Phone must be between 0 and 999999999999999999.")]
        public int phone { get; set; }

        [StringLength(15, ErrorMessage = "IP address cannot be longer than 15 characters.")]
        public string ipAddress { get; set; }

        [StringLength(255, ErrorMessage = "AFID cannot be longer than 255 characters.")]
        public string AFID { get; set; }

        [StringLength(255, ErrorMessage = "SID cannot be longer than 255 characters.")]
        public string SID { get; set; }

        [StringLength(255, ErrorMessage = "AFFID cannot be longer than 255 characters.")]
        public string AFFID { get; set; }

        [StringLength(255, ErrorMessage = "C1 cannot be longer than 255 characters.")]
        public string C1 { get; set; }

        [StringLength(255, ErrorMessage = "C2 cannot be longer than 255 characters.")]
        public string C2 { get; set; }

        [StringLength(255, ErrorMessage = "C3 cannot be longer than 255 characters.")]
        public string C3 { get; set; }

        [StringLength(255, ErrorMessage = "AID cannot be longer than 255 characters.")]
        public string AID { get; set; }

        [StringLength(255, ErrorMessage = "OPT cannot be longer than 255 characters.")]
        public string OPT { get; set; }

        [StringLength(255, ErrorMessage = "Click ID cannot be longer than 255 characters.")]
        public string click_id { get; set; }

        public int prospectId { get; set; }
    }

    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();
        User GetUserByID(int id);
        User GetUserByEmail(string email);
        User CreateUser(User user);
        void DeleteUser(int userId);
        void UpdateUser(User user);
        void Save();
    }

    public class UserRepository : IUserRepository, IDisposable
    {
        private ApplicationContext context;

        public UserRepository (ApplicationContext context)
        {
            this.context = context;
        }

        public void DeleteUser(int userId)
        {
            User user = context.Users.Find(userId);
            context.Users.Remove(user);
            Save();
        }

        public User GetUserByEmail(string email)
        {
            return context.Users.Where(u => u.email == email).FirstOrDefault();
        }

        public User GetUserByID(int id)
        {
            return context.Users.Find(id);
        }

        public IEnumerable<User> GetUsers()
        {
            return context.Users.ToList();
        }

        public User CreateUser(User user)
        {
            context.Users.Add(user);
            Save();
            return user;
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            context.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Save();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
