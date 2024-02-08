

using ConsoleApp_generics;

///generics helps in three issues:
///1-in performance => no need to boxing and unboxing===>effciency
///2-type safety==>avoid mistakes
///3-reusabilty==>one method operates on many types
var product = new Product(1, "tea", 100m);
Usefull.Print<Product>(product);
var emp = new Employee(1, "sulaiman");
Usefull.Print<Employee>(emp);
//===========================================================================================//
var any = new SList<int>();
any.Add(1);
any.Display();
any.Add(2);
any.Display();
any.Add(3);
any.Display();
any.RemoveAt(1);
any.Display();
any.RemoveAt(1);
any.Display();
any.RemoveAt(0);
any.Display();
