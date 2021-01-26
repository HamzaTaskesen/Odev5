using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5
{
    class VerifyManager
    {
        public void Verification(Player player, User user)
        {
            if (player.CitizenNumber == user.CitizenNumber && player.FirstName == user.FirstName && player.LastName == user.LastName && player.DateOfBirth == user.DateOfBirth)
            {
                Console.WriteLine("User Name Succeed");
            }
            else
            {
                Console.WriteLine("Unknown User Name Please Be Sure User Name Is Correct ");
            }
        }
    }
}
