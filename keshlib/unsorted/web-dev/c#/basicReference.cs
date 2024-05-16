// functions and variables


// normal function
void SayHello(string name)
{
  Console.WriteLine($"Hello {name}");
}

SayHello("Rishi");

// static allows methos to be called without creating an instance of the class

static void SayHello(string name)
{
  Console.WriteLine($"Hello {name}");
}

// implicitly typed variables
var myString = "string value";
var myNumber = 123;

// other built-in data types
string myString = "value";
int myNumber = 123;
float myFloat = 999.99F
DateTime someDate = DateTime.Now;

// object oriented stuff

// create your own data types
record MyRecord(string fieldA, string fieldB);  // immutable
struct MyStruct // not stored on heap, but on thread's memory
{
  public string FieldA;
  public string FieldB;
}
class MyClass
{

}

// classes
public class MyClass
{

  protected void MyMethod()
  {
    Console.WriteLine("Hello");
  }
}

// access modifiers
public class MyClass    // visible to everyone, everywhere
private                 // scoped to class
protected               // scoped to those inherited
internal                // 
file                    // 

// methods can have modifiers (must be more restrictive than class)

// inherit classes with `abstract`
public abstract class BaseClass
{
  // can add `abstract` to methods too, to `override` them
  public abstract void MyMethod();
}
public class MyClass: BaseClass
{
  
  public averride void MyMethod()
  {
    Console.WriteLine("Hello");
  }
}

// classes can implement many interfaces
// interfaces define what methods and properties a class must implement
public interface IMyInterface
{
  void MyMethod();
}
public class MyClass: IMyInterface
{

  public void MyMethod()
  {
    Console.WriteLine("Hello");
  }
}

// properties, getters, setters
public class MyClass
{
  // nice shorthand syntax
  public string MyProperty { get; set; }
  public int OtherProperty { get; set; }

  // expand properties
  private int _expandedProperty;
  public int ExpandedProperty
  {
    get { return _expandedProperty; }
    set { _expandedProperty = value; }
  }

  // add access modifiers to getting and setting
  public int RestrictedProperty { get; private set; }

  // nice shorthand for read-only properties
  public string MyProperty => "VALUE";
  // above is equivalent to:
  public string MyPropertyA
  {
    get
    {
      return "VALUE";
    }
  }

}

// classes have constructors and deconstructors
// you use constructors to create new instances of the class
// in js, deconstructing is like array destructuring
public class MyClass
{
  public string ValueA { get; }

  public MyClass(string valueA)
  {
    ValueA = valueA;
  }

  public void Deconstruct(out string valueA)
  {
    valueA = this.ValueA;
  }
}

// an example of a constructing and instance
var instance = new MyClass("one", "two");

// an example of deconstructing (destructuring)
var (one, two) = instance;

public class MyClass
{
  public string ValueA { get; }
  public string ValueB { get; }

  public MyClass(string valueA, string valueB)
  {
    ValueA = valueA;
    ValueB = valueB;
  }

  public void Deconstruct(out string valueA, out string valueB)
  {
    valueA = this.ValueA;
    valueB = this.ValueB;
  }
}

// records can be deconstructed too
var instance = new MyRecord("one", "two");
var (one, two) = instance;
record MyRecord(string one, string two);



// control flow stuff


// curly braces only required for 1+ statements
var val = true;
if (val == true)
{
  Console.WriteLine("True");
}
else if (val == false)
{
  Console.WriteLine("False")'
}

// switch statement
var value = 55;

string MyFunction(int value)
{
  switch (value)
  {
    case 1: return "one";
    case 2: return "two";
    case > 10: return "Large number";
    default: return "unknown";
  }
}

// c# offers a more functional syntax
string MyFunctionA(int value) =>
  value switch
  {
    1 => "one",
    2 => "two",
    > 10 => "Large number",
    _ => "unknown"
  };

// for loop
for(var i = 0; i < 10; i ++)
{
  Console.WriteLine(i);
}

// do while loop
var j = 0;
do
{
  Console.WriteLine(j);
  j++;
} while (j < 10);

// for each loop
var values = Enumerable.Range(1, 10).ToArray();
foreach(var value in values)
{
  Console.WriteLine(value);
}



// collection types
// they implement an interface called IEnumerable

var myArray = new string[5];

// standard library has more
using System.Collections;

var myList = new List<string>();
var myDictionary = new Dictionary<int, int>();
var myQueue = new Queue<string>();

// the IEnumerable interface
using System.Collections;

class MyEnumerable : IEnumerable
{
  private readonly string[] _data = new string[] { "one", "two" };

  public IEnumerator GetEnumerator()
  {
    return _data.GetEnumerator();
  }
}

// functions can return an IEnumerable
// with the `yield` statement, make an infinite array
using System.Collections;

IEnumerable<int> InfiniteArray()
{
  var i = 0;
  while (true)
  {
    yield return i;
    i++;
  }
}

// yield is better to defer execution while iterating
// over a dataset
using System.Collections;

IEnumerable<int> SquareEach(IEnumerable<int> data)
{
  foreach(var item in data)
  {
    var squared = Math.Pow(item, 2);
    yield return item;
  }
}

// IEnumerable comes with functions similar to
// map and reduce, called Select and Aggregate
// and others
using System.Collections;

var myArray = new int[] { 1, 2, 3 };

var result = myArray.Select(x => x * 10).Aggregate(0, (acc, cur) => acc + cur * 2);

// c# can control asynchronous code execution
async Task SomeAsyncFunction()
{
  await Task.Delay(1000);
  await Task.Delay(500);
}

// generics
string GenericFunction<T>() where T : IThing
{
  return typeof(T).GetType().Name;
}
