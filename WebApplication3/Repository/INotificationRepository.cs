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
        void Create(string text);
        void ReadNotification(int notificationId, string userId);
    }
}
