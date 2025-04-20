
// See https://aka.ms/new-console-template for more information
using libplctag;
using System;

Console.WriteLine("PLC Connection test utility!");

TestPLC.TestPLc.initialize_plc();
try
{
    TestPLC.TestPLc.strTag.Initialize();
    while (true)
    {
        try
        {
            Console.WriteLine("PLC status " + TestPLC.TestPLc.strTag.GetStatus());
            TestPLC.TestPLc.strTag.Read();
            Console.WriteLine("Tag value " + TestPLC.TestPLc.strTag.Value);
            TestPLC.TestPLc.intTag.Read();
            Console.WriteLine("Tag value " + TestPLC.TestPLc.intTag.Value);
            Thread.Sleep(1000);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Exception caught PLC status " + TestPLC.TestPLc.strTag.GetStatus());
            Thread.Sleep(2000);
        }
    }            
}
catch(Exception ex)
{
    Console.WriteLine(ex.ToString());
}

