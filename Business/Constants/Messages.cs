using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string SucceedAdded = "Car has been successfully added.";
        public static string InvalidAdded = "Car description must be minimum 2 characters and daily price must be greater than 0.";
        public static string MaintananceTime = "Maintanance time.Please check it later!";

        public static string CustomerAdded = "Customer has been added.";
        public  static string CustomerDeleted = "Customer has been deleted.";
        public static string CustomerUpdated = "Customer has been updated.";
        public static string CustomerListed = "Customer has been listed.";

        public  static string UserAdded = "user has been added.";
        public  static string UserUpdated = "user has been updated.";
        public static string UserDeleted = "user has been deleted.";
        public  static string UserListed = "user has been listed.";

        public  static string RentalDeleted = "Rental has been deleted.";
        public static string RentalListed = "Rental has been listed.";
        public static string RentalUpdated = "Rental has been updated.";
        public  static string SuccedRentalAdded = "Rental has been added.";
        public static string FailRentalAdded = " In order for the car to be rented, it must be delivered.Please check it later!";
        internal static string ColorAdded;
        internal static string ColorUpdated;
        internal static string ColorDeleted;
        internal static string BrandAdded;
        internal static string BrandUpdated;
        internal static string BrandDeleted;
        internal static string CarUpdated;
        internal static string CarDeleted;
    }
}
