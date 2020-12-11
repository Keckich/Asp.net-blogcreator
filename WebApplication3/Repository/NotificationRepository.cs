using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication3.Data;
using WebApplication3.Hubs;
using WebApplication3.Models;

using Microsoft.AspNetCore.Mvc;


namespace WebApplication3.Repository
{
    public class NotificationRepository : INotificationRepository
    {
        private ApplicationDbContext db;
        private IHubContext<NotificationHub> _hubContext;
        public NotificationRepository(ApplicationDbContext context, IHubContext<NotificationHub> hubContext)
        {
            db = context;
            _hubContext = hubContext;
        }

        public async Task Create(string text, string url)
        {
            var users = db.Users.ToList();
            foreach (var user in users)
            {
                if (user.Notifications)
                {
                    var userNotification = new NotificationUser();
                    userNotification.UserId = user.Id;
                    userNotification.Text = text;
                    
                    db.UserNotifications.Add(userNotification);
                    db.SaveChanges();
                }
                else
                {
                    continue;
                }
            }
            
            await _hubContext.Clients.All.SendAsync("displayNotification", "");
            foreach (var user in users)
            {
                if (user.Notifications)
                {
                    EmailService emailService = new EmailService();
                    await emailService.SendEmailAsync(user.Email, "Новый пост", $"Здравствуйте, {user.UserName}! У нас вышел новый пост! " +
                        $"Для просмотра перейдите по ссылке: {url}.");
                }
                else
                {
                    continue;
                }
            }
        }

        public List<NotificationUser> GetUserNotifications(string userId)
        {
            return db.UserNotifications.Where(u => u.UserId.Equals(userId) && !u.IsRead)                                       
                                       .ToList();
               
        }

        public void ReadNotification(int notificationId, string userId)
        {
            var notification = db.UserNotifications
                                 .FirstOrDefault(n => n.UserId.Equals(userId)
                                 && n.Id == notificationId);
            notification.IsRead = true;
            db.UserNotifications.Update(notification);
            db.SaveChanges();
        }
    }
}
