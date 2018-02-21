using System;
using System.Collections.Generic;
using System.Linq;

public class Family
{
    private List<Person> family;

    public Family()
    {
        this.family = new List<Person>();
    }

    public Family(Person person) : this()
    {

    }

    public void AddMember(Person member)
    {
        family.Add(member);
    }

    public Person GetOldestMember()
    {
        return family.OrderByDescending(a => a.Age).FirstOrDefault();
    }
}
