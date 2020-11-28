using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;
using WebApplication3.Repository;

namespace WebApplication3.Controllers
{
    public class NotificationController : Controller
    {
        private INotificationRepository _notificationRepository;
        private UserManager<ApplicationUser> _userManager;

        public NotificationController(INotificationRepository notificationRepository, UserManager<ApplicationUser> userManager)
        {
            _notificationRepository = notificationRepository;
            _userManager = userManager;
        }

        public IActionResult GetNotification()
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            var notification = _notificationRepository.GetUserNotifications(userId);
            return Ok(new { UserNotification = notification, Count = notification.Count });
        }

        public IActionResult ReadNotification(int notificationId)
        {
            _notificationRepository.ReadNotification(notificationId, _userManager.GetUserId(HttpContext.User));
            return Ok();
        }
    }
}
