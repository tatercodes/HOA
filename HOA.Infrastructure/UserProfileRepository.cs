using HOA.Application.Interfaces.ManageUser;
using HOA.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HOA.Infrastructure
{
    public class UserProfileRepository : IUserProfileRepository
    {
        private readonly SmartCertifyContext _context;

        public UserProfileRepository(SmartCertifyContext context)
        {
            _context = context;
        }

        public async Task UpdateUserProfilePicture(int userId, string pictureUrl)
        {
            var user = await _context.UserProfiles.FindAsync(userId);
            if (user != null)
            {
                user.ProfileImageUrl = pictureUrl;
                await _context.SaveChangesAsync();
            }
        }

        public async Task<UserProfile?> GetUserInfoAsync(int userId)
        {
            var user = await _context.UserProfiles.FirstOrDefaultAsync(f => f.UserId == userId);
            return user;
        }
    }
}
