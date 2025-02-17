namespace SellBook.Utility
{
    public static class SD // static data
    {
        public const string Role_User_Cust = "Customer";
        public const string Role_User_Comp = "Company";
        public const string Role_User_Admin = "Admin";
        public const string Role_User_Employee = "Employee";

        // Const for order status
        public const string StatusPending = "Pending";
        public const string StatusApproved = "Approved";
        public const string StatusInProcess = "Processing";
        public const string StatusShipped = "Shipped";
        public const string StatusCancelled = "Cancelled";
        public const string StatusRefunded = "Refunded";

        // Const for payment status
        public const string PaymentStatusPending = "Pending";
        public const string PaymentStatusApproved = "Approved";
        public const string PaymentStatusDelayPayment = "ApprovedForDelayedPayment";
        public const string PaymentStatusRejected = "Rejected";
    }
}
