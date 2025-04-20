# plc_communication
- How to connect to a ControlLogix via Ethernet / IP
- How to create bindings between tags and properties
- Basic techniques and tools to test your PLC program

# Reference library (libplctag)
  Donwload libplctg.NET https://github.com/libplctag/libplctag.NET/tree/main.
  libplctag is an open source C library for Linux, Windows and macOS using EtherNet/IP or Modbus TCP to read and write tags in PLCs.

  libplctag.NET provides .NET wrapper packages for libplctag, and publishes them to Nuget.org.

# Initialize Tags
  # String type TAG
    public static Tag<StringPlcMapper, string> strTag = new Tag<StringPlcMapper, string>()
    {
        Name = "TAG_NAME",
        Gateway = "PLC IP Address (i.e 192.168.0.100)",
        Path = "communication path (Default is -> 1,0)",
        Protocol = Protocol Type (Modbus/ab_eip),
        PlcType = PlcType (ControlLogix)
        Timeout = timeout in second
    };
  # Integer type TAG
    public static Tag<DintPlcMapper, int> intTag;
    {
        Name = "TAG_NAME",
        Gateway = "PLC IP Address (i.e 192.168.0.100)",
        Path = "communication path (Default is -> 1,0)",
        Protocol = Protocol Type (Modbus/ab_eip),
        PlcType = PlcType (ControlLogix)
        Timeout = timeout in second
    };
  
  
