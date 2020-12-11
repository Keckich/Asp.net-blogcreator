using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Models;

namespace WebApplication3.Repository
{
    public interface INotificationRepository
    {
        List<NotificationUser> GetUserNotifications(string userId);
        Task Create(string text, string url);
        void ReadNotification(int notificationId, string userId);
    }
}
