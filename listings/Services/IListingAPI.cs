using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using listings.Models;

namespace listings.Services
{
    public interface IListingAPI
    {
//        [Get("/5ce3a2593100008400742770")]
        [Get("/announcement")]
        Task<List<Announcement>> GetAnnouncements();
        
        [Get("/categories")]
        Task<List<Category>> GetCategories();

        [Post("/auth")]
        Task<Token_API> Login([Body] Credentials credentials);
        
        [Post("/announcement")]
        [Headers("Authorization: Bearer")]
        Task<Announcement> PostAnnouncement([Body] Announcement announcement);
        
        [Get("/messages/received")]
        [Headers("Authorization: Bearer")]
        Task<List<Message>> GetReceivedMessages();
        
        [Get("/messages/sent")]
        [Headers("Authorization: Bearer")]
        Task<List<Message>> GetSentMessages();

        [Post("/messages")]
        [Headers("Authorization: Bearer")]
        Task<Announcement> PostMessage([Body] MessageApi message);
        
        [Get("/users/me")]
        [Headers("Authorization: Bearer")]
        Task<User> GetUser();
    }
}