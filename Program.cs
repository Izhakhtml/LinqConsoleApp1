using LinqConsoleApp1;

//int[] numArray = new int[10] ;

//Random random = new Random();
//int i = 0;
//while (i < 10)
//{
//    numArray[i] = random.Next(0, 10);
//    //Console.WriteLine(numArray[i]);
//    i++;
//}

//List<int> list = new List<int>();
//list = numArray.Where(item => item % 2 == 0).ToList();
//int x= 0;
//while (x < list.Count())
//{
//    //Console.WriteLine(list[x]);
//    x++;
//}

//List<int> biggerList = new List<int>();
//biggerList = numArray.Where(item => item > 4).OrderBy(item =>item).ToList();
//int y = 0;
//while (y < biggerList.Count())
//{
//    //Console.WriteLine(biggerList[y]);
//    y++;
//}
//string[] nameArray = new string[] {"izhak","shay","avrham","moshe","raovenn"};
//List<string> listArray = new List<string>();
//listArray = nameArray.Where(item => item.Length > 4).OrderByDescending(item => item).ToList();
//for(int icou = 0; icou < listArray.Count(); icou++)
//{
//    //Console.WriteLine(listArray[icou]);
//}

//Person[] arrayPerson = new Person[]
//{
//    new Person("izhak", "lijalem", 1990),
//    new Person("shay", "bbbbb", 1955),
//    new Person("baruch", "ccccc", 1990),
//    new Person("idan", "dddd", 1934),
//    new Person("ori", "xxxx", 1928),
//    new Person("bar", "pppp", 1998),
//};

//List<Person> listPesrsons = new List<Person>();
//listPesrsons = arrayPerson.Where(item=> item.firstName.Length>3).OrderBy(item=>item.birthYear).ToList();
//for (int index = 0; index < listPesrsons.Count(); index++)
//{
//    //Console.WriteLine(listPesrsons[index].firstName);
//    //Console.WriteLine(listPesrsons[index].lastName);
//    //Console.WriteLine(listPesrsons[index].birthYear);
//}
//Person num = listPesrsons.Find(item => item.birthYear == 1934);
//Console.WriteLine(num.birthYear);

/// exe 1 //

string[] namesArray = new string[] { "Izhak", "Noam", "avi", "Ido", "Adam" };
List<string> listNames = new List<string>();
//listNames = namesArray.Where(item =>item.ToLower()[0] == 'a').ToList();
var list = from item in namesArray
           where item.ToLower()[0] == 'a'
           select item;
//foreach(var item in list)
//{
//Console.WriteLine(item);
//}

/// exe 2 //

int[] numbersArray = new int[] { 12, 43, 55, 43, 66, 2, 4, 5, 6, 17 };
List<int> listNumbers = new List<int>();
var list2 = from item in numbersArray
            where item > 18
            select item;
//foreach (var item in list2)
//{
//    Console.WriteLine(item);
//}

/// exe 3 //

List<Person> listsObjects = new List<Person>();
listsObjects.Add(new Person("aa","bbb",2010,20,"lod"));
listsObjects.Add(new Person("cc", "dddn", 1990,21,"tel-aviv"));
listsObjects.Add(new Person("bb", "fffff", 1998,22,"lod"));
listsObjects.Add(new Person("ff", "bbb", 1992,21, "tel-aviv"));
listsObjects.Add(new Person("gg", "bbbbbN", 1993,24,"lod"));
listsObjects.Add(new Person("ee", "bbb", 1978,28, "tel-aviv"));
var list3 = from item in listsObjects
            where item.age > 21
            select item;
//foreach (var item in list3)
//{
//    Console.WriteLine(item.firstName);
//    Console.WriteLine(item.lastName);
//    Console.WriteLine(item.birthYear);
//    Console.WriteLine(item.age);
//}

/// exe 4 //
var list4 = from item in listsObjects
            where item.lastName.Length > 4
            select item;
//foreach (var item in list4)
//{
//    Console.WriteLine(item.firstName);
//    Console.WriteLine(item.lastName);
//    Console.WriteLine(item.birthYear);
//    Console.WriteLine(item.age);
//}

/// exe 5 //

var list5 = from item in listsObjects
            where item.age > 25
            select item;
//foreach (var item in list5)
//{
//    Console.WriteLine(item.firstName);
//    Console.WriteLine(item.lastName);
//    Console.WriteLine(item.birthYear);
//    Console.WriteLine(item.age);
//}

/// exe 6 //

var list6 = from item in listsObjects
            where item.lastName.ToLower()[item.lastName.Length-1] == 'n'
            select item;
//foreach (var item in list6)
//{
//    Console.WriteLine(item.firstName);
//    Console.WriteLine(item.lastName);
//    Console.WriteLine(item.birthYear);
//    Console.WriteLine(item.age);
//}

/// exe 7 + 8 //

var list7 = 
    from item in listsObjects
    group item by item.lastName;

//foreach (var item in list7)
//{
//    Console.WriteLine($"group name :{item.Key}");
//    foreach (Person itemPerson in item)
//    {
//        Console.WriteLine(itemPerson.firstName);
//    }
//}

/// exe 9 + 10 + 11//
var list10 = 
    from item in listsObjects
    group item by item.city;
foreach (var item in list10)
{
    Console.WriteLine($"group name :{item.Key}");
    foreach (Person itemPerson in item)
    {
        Console.WriteLine(itemPerson.firstName);
    }
}

/// exe 12 ///