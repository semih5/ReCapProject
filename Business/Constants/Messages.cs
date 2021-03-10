using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        public static string Added = "Car added.";
        public static string NotAdded = "Couldn't be added";
        public static string Deleted = "Car deleted.";
        public static string NotDeleted = "Couldn't be deleted.";
        public static string Updated = "Car updated.";
        public static string NotUpdated = "Couldn't be updated.";
        public static string NameInvalid = "Car name invalid.";
        public static string MaintenanceTime = "Maintenance time.";
        public static string Listed = "Cars listed.";
        public static string NotListed = "Couldn't be listed.";

        public static string AuthorizationDenied = "Authorization denied.";
        public static string AccessTokenCreated = "Access token created.";
        public static string UserNotFound = "User not found";
        public static string PasswordError = "Password error";
        public static string SuccessfulLogin = "Successful login";
        public static string UserAlreadyExists = "User already exists";
        public static string UserRegistered = "User registered";
    }

}

