using System;

public struct Name
{
    private string fName, mName, lName;

    public Name(string first, string middle, string last)
    {
        fName = first;
        mName = middle;
        lName = last;
    }

    public string firstName
    {
        get
        {
            return fName;
        }

        set
        {
            fName = firstName;
        }
    }

    public string middleName
    {
        get
        {
            return mName;
        }

        set
        {
            mName = middleName;
        }
    }

    public string lastName
    {
        get
        {
            return lName;
        }

        set
        {
            lName = lastName;
        }
    }

    public override string ToString()
    {
        return (String.Format("{0} {1} {2}", fName, mName, lName));
    }

    public string Initials()
    {
        return (String.Format("{0}{1}{2}", fName.Substring(0, 1), mName.Substring(0, 1), lName.Substring(0, 1)));
    }

}

public class NameTest
{
    static void Main()
    {
        Name myName = new Name("Michael", "Mason", "McMillan");
        string fullName, inits;

        // no use here in this case but don't know why?
        myName.lastName = "Gao";

        fullName = myName.ToString();
        inits = myName.Initials();
        Console.WriteLine("My name is {0}", fullName);
        Console.WriteLine("My initials are {0}", inits);
    }
}