# plc_communication
- How to connect to a ControlLogix via Ethernet / IP
- How to create bindings between tags and properties
- Basic techniques and tools to test your PLC program

# Reference library (libplctag)
  https://github.com/libplctag/libplctag.NET/tree/main

# Initialize Tags
  # String type TAg
  public static Tag<StringPlcMapper, string> strTag;
  # Integer type TAg
  public static Tag<DintPlcMapper, int> intTag;
  
  public static Tag<StringPlcMapper, string> strTag = new Tag<StringPlcMapper, string>()
  {
      Name = "TAG1_NAME",
      Gateway = "PLC IP Address (i.e 192.168.0.100)",
      Path = "communication path (Default is -> 1,0)",
      Protocol = Protocol Type (Modbus/ab_eip),
      PlcType = PlcType (ControlLogix)
      Timeout = timeout in second
  };
