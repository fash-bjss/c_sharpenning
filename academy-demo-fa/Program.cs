// See https://aka.ms/new-console-template for more information

// These are like imports
using academy_demo_fa;
using academy_demo_fa.radio;
using academy_demo_fa.calc;
using academy_demo_fa.cars;

Person p = new Person("Sade", 65); 
// No longer can be set as set is private (can be removed to make public) { Name = "Sade", Age=65};


Console.WriteLine("Hello, my name is " + p.Name);
// Using the in built method
Console.WriteLine(p.introduce());
Console.WriteLine(p.sayAge());

p.updateName("Burna Boy");
//p.Name = "Hello"; cannot be set as set is private

Console.WriteLine(p.introduce());

p.updateAge(33);

Console.WriteLine(p.sayAge());

p.updateNameAndAge("Tiwa Savage", 44);

Console.WriteLine(p.introduce());
Console.WriteLine(p.sayAge());
Console.WriteLine("\n");
// Class using an interface
/*
* An interface is a contract. It states that all things that use (implement) 
* that interface are guaranteed to have exactly the methods and properties defined 
* in the interface. But the interface itself contains no executable code.
*/
MP3Media mp3 = new MP3Media();
mp3.Play();

CDMedia cd = new CDMedia();
cd.Play();

RecordMedia recordM = new RecordMedia();
recordM.Play();


/* Creating a list in C# - in this instance we pass in the interface as we want
the list to have multiple types so we use the interface to include all the types 
the interface has a contract with.*/

List<IMedia> playlist = new List<IMedia>();

playlist.Add(new MP3Media());
playlist.Add(new CDMedia());
playlist.Add(new RecordMedia());
playlist.Add(new CDMedia());
playlist.Add(new MP3Media());
playlist.Add(new MP3Media());
playlist.Add(new CDMedia());
playlist.Add(new RecordMedia());
Console.WriteLine("\n");

// Counting items in a list
Console.WriteLine(playlist.Count + " Records in playlist");
Console.WriteLine("\n");

// Looping through a list in C#
/*
 Now we can loop through the list that have different types, but
share the same interface and run the Play() method on them with 
differring results
 */
foreach (IMedia media in playlist)
{
    media.Play();
    try
    {
        media.Stop();
    } catch  {
        Console.WriteLine("There was an error stopping the media from playing");
    }
    
}
Console.WriteLine("\n");

// Add two Cassette types to playlist
playlist.Add(new CassetteMedia());
playlist.Add(new CassetteMedia());

Console.WriteLine("Added two Cassette Media types");

for(int i = 0; i < playlist.Count; i++)
{
    playlist[i].Play();

    try
    {
        playlist[i].Stop();
    }
    catch
    {
        Console.WriteLine("There was an error stopping the media from playing");
    }
}
Console.WriteLine("\n");

// Exceptions using try catch

Calculator calculator = new Calculator();

try
{
    Double result = calculator.Divide(10, 5);
    Console.WriteLine(result);
} catch (DivideByZeroException)
{   
    throw;
}
catch (Exception ex)
{
    // Catching every other exception apart from Divide by Zero
    Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@");
    Console.WriteLine(ex.Message);
    Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@");
    Console.WriteLine(ex.ToString());

}
finally
{
    Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@");
    Console.WriteLine("Thank You for running the code");
}
Console.WriteLine("\n");

IEngine engine1600 = new Engine1600();
IEngine engine2000 = new Engine2000();

BaseHeadlights neon = new NeonHeadlights();
BaseHeadlights normal = new NormalHeadlights();

Academy500Roadster roadster1 = new Academy500Roadster(engine1600, neon);
Academy500Roadster roadster2 = new Academy500Roadster(engine2000, normal);

Console.WriteLine(roadster1.Engine.EngineSize);
Console.WriteLine(roadster2.Engine.EngineSize);

Console.WriteLine("####### Roadser with Engine1600");

for(int i = 0; i < 100; i++)
{
    roadster1.Accelerate();
}

Console.WriteLine(roadster1.Speed);
Console.WriteLine("\n");

Console.WriteLine("####### Roadser with Engine2000");

for(int i = 0; i < 120; i++)
{
    roadster2.Accelerate();
}
Console.WriteLine(roadster2.Speed);

Console.WriteLine("\n");

Console.WriteLine("The Roadster2000 is moving at " + roadster2.Speed.Mph);

roadster2.Brake();

Console.WriteLine("The Roadster2000 is moving at " + roadster2.Speed.Kph);


BaseHeadlights headlights = new NormalHeadlights();
IEngine engine = new Engine1600();

Academy500Roadster roadster = new Academy500Roadster(engine, headlights);

roadster.Accelerate();
roadster.Accelerate();
roadster.Accelerate();
roadster.Headlights.FullBeam();

Console.WriteLine("The car is going " + roadster.Speed.Mph + "mph and the headlights are " + roadster.Headlights.Status);

//let's replace our instances
headlights = new NeonHeadlights();
roadster = new Academy500Roadster(engine, headlights);

roadster.Accelerate();
roadster.Accelerate();
roadster.Accelerate();
roadster.Headlights.FullBeam();

Console.WriteLine("The car is going " + roadster.Speed.Kph + "mph and the headlights are " + roadster.Headlights.Status);

Console.WriteLine("\n");

Console.WriteLine("The car is going " + roadster.Speed.Mph + "mph and the headlights are " + roadster.Headlights.Status);



