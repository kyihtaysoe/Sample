using System;
using System.Collections.Generic;
using System.Text;

namespace sample
{
    public class Member
    {
        int Id { get; set; } ///uniqure
        string Birthday { get; set; }
        string Address { get; set; }
        string Sex { get; set; }

        private DateTime RandomDay()
        {
            Random gen = new Random();
            DateTime start = new DateTime(1995, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(gen.Next(range));
        }

        public List<Member> GenerateMembers(int count = 1000)
        {
            List<Member> members = new List<Member>();
            for (int i = 0; i < count; i++)
            {
                Member member = new Member
                {
                    Id = i + 1,
                    Birthday = RandomDay().ToString("yyyyMMdd"),
                    Address = $"Address {i}",
                    Sex = i % 2 == 0 ? "Male" : "Female"
                };
                members.Add(member);
            }
            return members;
        }


    }
}
