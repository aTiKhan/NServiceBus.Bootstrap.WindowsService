﻿using NServiceBus.Serilog;
using Serilog;
using Serilog.Events;

class LoggingConfig
{
    public static void ConfigureLogging()
    {
        Log.Logger = new LoggerConfiguration()
            .WriteTo.ColoredConsole(LogEventLevel.Information)
            .WriteTo.RollingFile("log-{Date}.txt", LogEventLevel.Information)
            .CreateLogger();

        SerilogConfigurator.Configure();
    }
}