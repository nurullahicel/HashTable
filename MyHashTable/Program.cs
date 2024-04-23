using MyHashTable;

MyHashTable.MyHashTable mht=new MyHashTable.MyHashTable();

mht.Set(1102,"1234124");
mht.Set(1134,"321345");
mht.Set(1595,"421344");
mht.Set(1596,"565886");
mht.Set(1877,"978987987");
mht.Set(1873,"213415");


Console.WriteLine(mht.Get(1102));
Console.WriteLine(mht.Get(1134));
Console.WriteLine(mht.Get(1595));
Console.WriteLine(mht.Get(1596));
Console.WriteLine(mht.Get(1877));
Console.WriteLine(mht.Get(1873));