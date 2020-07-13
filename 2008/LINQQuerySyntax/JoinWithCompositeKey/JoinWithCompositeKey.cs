using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class UserGroupMember
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public UserGroupMember(string FirstName, string LastName)
    {
        this.FirstName = FirstName;
        this.LastName = LastName;
    }
}

public class JoinWithCompositeKey
{
    public static void Main(string[] args)
    {
        UserGroupMember[] CNYDeveloperGroup =
        {
            new UserGroupMember ( "Andy", "Beaulieu" ),
            new UserGroupMember ( "David", "Stevenson" ),
        };
        UserGroupMember[] WNYDNUG = 
        {
            new UserGroupMember ( "David", "Hockenberry" ),
            new UserGroupMember ( "Michael", "Pawelek" ),
            new UserGroupMember ( "David", "Stevenson" ),
            new UserGroupMember ( "Bob", "Nims" ),
        };

        var query = from u1 in CNYDeveloperGroup
                    join u2 in WNYDNUG
                    on new { u1.FirstName, u1.LastName } equals
                        new { u2.FirstName, u2.LastName }
                    select u1;

        foreach (var member in query)
            Console.WriteLine("{0} {1}", 
                member.FirstName, member.LastName);

        Console.WriteLine();
        Console.ReadKey();
    }
}

