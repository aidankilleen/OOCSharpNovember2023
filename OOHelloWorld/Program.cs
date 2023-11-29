using OOHelloWorld;

Console.WriteLine("OO Hello World");

//Message m = new Message();

//m.title = "Message 1";
//m.text = "This is message 1";

//m.Display();

Message m1 = new Message("M1", "this is m1");
//m1.delay = -1000;
//m1.SetDelay(-1000);
m1.Delay = 20;


m1.Delay = -1000;

// m1.title = "CHANGED TITLE";


Message m2 = new Message("M2", "This is m2");

m1.Display();
m2.Display();
