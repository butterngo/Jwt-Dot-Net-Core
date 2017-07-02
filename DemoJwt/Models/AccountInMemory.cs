namespace DemoJwt.Models
{
    using System;
    using System.Collections.Generic;

    public static class AccountInMemory
    {
        public static IList<Account> ArrayAccount = new List<Account>();

        static AccountInMemory()
        {
            ArrayAccount.Add(new Account
            {
                Id = Guid.NewGuid().ToString("n"),
                FirstName = "Butter",
                LastName = "Ngo",
                UserName ="admin",
                Password = "123456"
            });
        }
    }
}
