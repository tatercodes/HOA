using HOA.Application.Interfaces.ManageUser;
using HOA.Domain.Entities;

namespace HOA.Application.Services.ManageUser
{
    public class UserProfileService : IUserProfileService
    {
        private readonly IUserProfileRepository userProfileRepository;

        public UserProfileService(IUserProfileRepository userProfileRepository)
        {
            this.userProfileRepository = userProfileRepository;
        }

        public async Task UpdateUserProfilePicture(int userId, string pictureUrl)
        {
            await userProfileRepository.UpdateUserProfilePicture(userId, pictureUrl);
        }      

        public Task<UserProfile?> GetUserInfoAsync(int userId)
        {
            return userProfileRepository.GetUserInfoAsync(userId);
        }
    }
}
