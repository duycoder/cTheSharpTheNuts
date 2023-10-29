using System;
using System.Collections.Generic;
using System.Text;
namespace Packt.Shared;

public class Person : object
{
    public string? Name;
    public DateTime? DateOfBirth;
    public WonderOfTheAncientWorld FavoriteAncientWonder;
    public WonderOfTheAncientWorld BucketList;
    public List<Person> Children = new();
}
