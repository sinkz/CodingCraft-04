using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace CodingCraft_04.infraestrcture.Membership
{
    public class CustomMembershipUser : MembershipUser
    {


        public string Name { get; set; }

        public CustomMembershipUser(
            string providername,
            string username,
            object providerUserKey,
            string email,
            string passwordQuestion,
            string comment,
            bool isApproved,
            bool isLockedOut,
            DateTime creationDate,
            DateTime lastLoginDate,
            DateTime lastActivityDate,
            DateTime lastPasswordChangedDate,
            DateTime lastLockedOutDate,
            string name) :
            base(providername,
                username,
                providerUserKey,
                email,
                passwordQuestion,
                comment,
                isApproved,
                isLockedOut,
                creationDate,
                lastLoginDate,
                lastPasswordChangedDate,
                lastActivityDate,
                lastLockedOutDate)
        {

            Name = name;

        }
    }


}